using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Administrator.Data;
using Administrator.Frames;
using Administrator.References;
using ALProjects.Core.Config;
using ALProjects.Security;
using log4net;
using log4net.Config;
using tAlert.DbVersion;

namespace Administrator
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        private static AdministratorDataContext currentDataContext;

        public static event EventHandler ConnectionStringChanged;



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            if (!initialize())
            {
                log.Info("Application wasn't initialized and will be close.");
                Notification.CantEstablishConnection();
                return;
            }

            // SecurityFacade.Instance.Login("test", "test");
            log.Info("Application started..");
            Application.Run(new MainFrame());
            log.Info("Application closed.");

        }

        private static bool initialize()
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Blue";
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Xmas 2008 Blue";

            XmlConfigurator.Configure();

            switch(SetUpConnection(false))
            {
                case ConnectionSetUpStates.Established:
                    return true;
                case ConnectionSetUpStates.NoChanges:
                case ConnectionSetUpStates.UpdateError:
                case ConnectionSetUpStates.FatalError:
                    return false;
            }

            return false;
        }

        internal static ConnectionSetUpStates SetUpConnection(bool ifExistsSetUpAnyway)
        {
            bool sqlConnectionChanged = false;
            try
            {
                #region initialize db connection

                if (ifExistsSetUpAnyway || !Utils.CheckConnection(Settings.Default.ConnectionString))
                {
                    using (ConnectionForm frame = new ConnectionForm())
                    {
                        frame.ConnectionString = Settings.Default.ConnectionString;
                        if (frame.ShowDialog() != DialogResult.OK)
                        {
                            return ConnectionSetUpStates.NoChanges;
                        }
                        sqlConnectionChanged = Settings.Default.ConnectionString != frame.ConnectionString;
                        Settings.Default.ConnectionString = frame.ConnectionString;
                        SqlConnectionStringBuilder builder =
                            new SqlConnectionStringBuilder(Settings.Default.ConnectionString);
                        Document document = new Document();
                        document.CreateDataBase(builder.InitialCatalog);
                        Settings.Default.Save();
                    }
                }
                var controller = new MsSqlVersionController(Settings.Default.ConnectionString);
                controller.Initialize();
                if (!controller.StartUpdateIfNeedIt())
                {
                    return ConnectionSetUpStates.UpdateError;
                }

                #endregion

                if (sqlConnectionChanged)
                {
                    OnConnectionStringChanged(EventArgs.Empty);
                }

                return ConnectionSetUpStates.Established;
            }
            catch (Exception ex)
            {
                log.Fatal("Can't initialize application", ex);
                return ConnectionSetUpStates.FatalError;
            }
        }

        internal static AdministratorDataContext CurrentDataContext
        {
            get
            {
                if (currentDataContext == null)
                {
                    currentDataContext = new AdministratorDataContext(Settings.Default.ConnectionString);
                }
                else
                {
                    if (Utils.GetDbName(Settings.Default.ConnectionString) != Utils.GetDbName(currentDataContext.Connection.ConnectionString))
                    {
                        currentDataContext = new AdministratorDataContext(Settings.Default.ConnectionString);
                    }
                }

                return currentDataContext;
            }
        }

        private static void OnConnectionStringChanged(EventArgs e)
        {
            EventHandler changed = ConnectionStringChanged;
            if (changed != null) changed(null, e);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            log.Fatal(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            log.Fatal(e.ExceptionObject as Exception);
        }

    }
}
