using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Lookups;

namespace ALProjects.Core.Objects.Security
{
    [System.Diagnostics.DebuggerStepThrough]
    [Serializable]
    public class LoginContext
    {
        #region members
        private UserInfo _userInfo;
        private Roles _userRole;
        private Rights _userRights;
        private String _userLogin;
        private DateTime _loginTime;
        #endregion

        #region ctors
        public LoginContext()
        {
            this._userInfo = new UserInfo();
            this._userRights = Rights.None;
            this._userRole = Roles.None;
        }
        public LoginContext(UserInfo info, Roles role, Rights rights, String login)
        {
            this._userInfo = info;
            this._userRole = role;
            this._userRights = rights;
            this._userLogin = login;
            this._loginTime = DateTime.Now;
        }
        #endregion

        #region public methods
        public UserInfo UserInfo
        {
            get { return this._userInfo; }
        }
        public Roles UserRole
        {
            get { return this._userRole; }
        }
        public Rights UserRights
        {
            get { return this._userRights; }
        }
        public String UserLogin
        {
            get { return this._userLogin; }
        }
        public DateTime LoginTime
        {
            get { return this._loginTime; }
        }
        #endregion
    }
}
