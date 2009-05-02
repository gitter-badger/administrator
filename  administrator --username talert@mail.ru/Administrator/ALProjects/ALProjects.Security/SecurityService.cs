using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using ALProjects.Common.AppState;
using ALProjects.Core;
using ALProjects.Core.Lookups;
using ALProjects.Core.Objects;
using ALProjects.Core.Objects.Security;
using ALProjects.Data.BusinessAccessLevel;
using log4net;

namespace ALProjects.Security
{
    internal class SecurityService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SecurityService));

        #region const

        public static readonly String LOGIN_CONTEXT = "Login Context";

        #endregion

        #region public methods

        public LoginContext LoginContext
        {
            get { return StateManager.Current.Session[LOGIN_CONTEXT] as LoginContext; }
        }

        public Boolean TryLogin(String login, String password)
        {
            try
            {
                Logoff();

                StateManager.Current.Session[LOGIN_CONTEXT]
                    = new LoginContext(new UserInfo(), Roles.Guest, Rights.ReadContent, "Guest");

                Int32 id = DataBusinessFacade.Instance.SecurityProvider.GetUserId(login, Utils.CalculateMD5Hash(password));
                if (id == 0)
                {
                    return false;
                }
                LoginContext context = DataBusinessFacade.Instance.SecurityProvider.GetLoginContext(id);
                if (context == null)
                {
                    return false;
                }
                StateManager.Current.Session[LOGIN_CONTEXT] = context;
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            return false;
        }

        public void Logoff()
        {
            StateManager.Current.Session[LOGIN_CONTEXT] = null;
        }

        public bool IsUserHasRights(Rights rights)
        {
            if (!IsUserAuthenticated())
            {
                return false;
            }
            return (LoginContext.UserRights & rights) == rights;
        }

        public bool IsUserInRole(Roles role)
        {
            if (!IsUserAuthenticated())
            {
                return false;
            }
            return LoginContext.UserRole == role;
        }

        public Boolean IsUserAuthenticated()
        {
            return StateManager.Current.Session[LOGIN_CONTEXT] != null;
        }

        #endregion

        #region private methods



        #endregion
    }
}