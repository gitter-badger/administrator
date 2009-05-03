using System;

namespace tAlert.DbVersion
{
    public class Version : IComparable<Version>,IComparable<string >
    {
        public Version(string version) : this(version, "")
        {
        }

        public Version(string version, string script)
        {
            this._version = version;
            this._script = script;
        }

        #region public properties
        
        public static Version Unknown
        {
            get { return new Version("0.0.0.0"); }
        }

        public string Script
        {
            get { return _script; }
        }

        #endregion

        #region public methods

        public bool IsLatestVersion(Version version)
        {
            return this.CompareTo(version) > 0;
        }

        #endregion

        #region overriden members
        public override string ToString()
        {
            return _version;
        }
        #endregion

        #region members

        private readonly string _version;
        private readonly string _script;

        #endregion

        public int CompareTo(Version version)
        {
            return CompareTo(version.ToString());
        }

        public int CompareTo(string version)
        {
            return this._version.CompareTo(version);
        }
    }
}