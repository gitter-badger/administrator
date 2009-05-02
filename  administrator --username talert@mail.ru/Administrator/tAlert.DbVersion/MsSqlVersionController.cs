using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using log4net;
using tAlert.DbVersion.Statements;

namespace tAlert.DbVersion
{
    

    public class MsSqlVersionController : IVersionController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof (MsSqlVersionController));

        #region ctors

        public MsSqlVersionController(String connectionString)
        {
            this.connectionString = connectionString;
            if (!CheckConnection()) return;

       }

        public void Initialize()
        {
            dbVersion = GetDbVersion();
            LoadScripts();
            scriptVersion = GetScriptVersion();

            log.InfoFormat("Current DB version is [{0}], actual DB version is [{1}]",dbVersion,scriptVersion);
        }

        #endregion

        #region IVersionController Members

        public Version GetDBVersion
        {
            get { return dbVersion; }
        }

        public bool NeedToBeUpdate()
        {
            return dbVersion.CompareTo(scriptVersion) < 0;
        }

        public bool StartUpdateIfNeedIt()
        {
            return StartUpdateIfNeedIt(scriptVersion);
        }

        public bool StartUpdateIfNeedIt(Version finalVersion)
        {
            if (!NeedToBeUpdate())
            {
                return true;
            }

            log.InfoFormat("Start update DB to [{0}]",scriptVersion);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                IDbCommand command = connection.CreateCommand();

                connection.Open();
                foreach (Version version in versions)
                {
                    if (version.IsLatestVersion(finalVersion)) return true;

                    if (!version.IsLatestVersion(dbVersion)) continue;
                    
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        command.Transaction = transaction;
                        try
                        {
                            if (!String.IsNullOrEmpty(version.Script))
                            {
                                var querryParts = SplitWithGo(version.Script);

                                foreach (string s in querryParts)
                                {
                                    command.CommandText = s;
                                    command.ExecuteNonQuery();
                                }

                                command.CommandText = MsSql.UpdateDbVersion;
                                command.Parameters.Clear();
                                addParameter(command, "@dbversion", version.ToString());
                                command.ExecuteNonQuery();
                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error("Update DB is faled",ex);
                            transaction.Rollback();
                            return false;
                        }

                        log.InfoFormat("DB is successfully updated to [{0}]", version.ToString());
                    }
                }
                return true;
            }
        }

        #region private members

        private static string[] SplitWithGo(string querry)
        {
            string[] result = querry.Split(new[] { "\nGO\r", "\ngo\r" }, StringSplitOptions.RemoveEmptyEntries);

            return result;
        }

        private bool CheckConnection()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        private Version GetDbVersion()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = MsSql.QuerryGetCurrentVersion;


                int tryCount = 5;
                while (tryCount > 0)
                {
                    try
                    {
                        connection.Open();
                        break;
                    }
                    catch (Exception)
                    {
                        log.Warn("Can't open connection");
                        Thread.Sleep(1000);
                        tryCount--;
                    }
                } 

                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Version((String) reader["version"]);
                    }
                }
            }
            return Version.Unknown;
        }

        private Version GetScriptVersion()
        {
            return versions[versions.Length - 1];
        }

        private void LoadScripts()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            String[] res = assembly.GetManifestResourceNames();

            List<Version> scripts = new List<Version>();

            for (int i = 0; i < res.Length; i++)
            {
                int index = res[i].IndexOf("sql");
                if (index != -1)
                {
                    string version = res[i].Substring(index - 8, 7);
                    using (StreamReader reader = new StreamReader(
                        assembly.GetManifestResourceStream(res[i]),
                        Encoding.GetEncoding(1251)))
                    {
                        string script = reader.ReadToEnd();

                        scripts.Add(new Version(version, script));
                    }
                }
            }
            versions = scripts.ToArray();
            Array.Sort(versions);
        }


        private void addParameter(IDbCommand command, string name, object value)
        {
            if (!command.Parameters.Contains(name))
            {
                command.Parameters.Add(new SqlParameter(name, value));
            }
        }

        #endregion

        #region members

        private readonly string connectionString;
        private Version dbVersion;
        private Version scriptVersion;
        private Version[] versions;

        #endregion

        #endregion
    }
}