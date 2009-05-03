using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Objects.Security;
using ALProjects.Core.Lookups;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace ALProjects.Security
{
    [System.Diagnostics.DebuggerStepThrough]
    public sealed class SecurityFacade
    {
        #region singlation
        private static readonly SecurityFacade _current = new SecurityFacade();

        
        public static SecurityFacade Instance
        {
            get { return _current; }
        }
        static SecurityFacade() { }
        private SecurityFacade() { }
        #endregion

        #region members
        private SecurityService _service = new SecurityService();
        #endregion

        #region public properties
        #endregion

        #region public methods
        public Boolean Login(String login, String password)
        {
            return this._service.TryLogin(login, password);
        }
        public void Logoff()
        {
            this._service.Logoff();
        }
        public Boolean IsUserAuthenticated()
        {
            return this._service.IsUserAuthenticated();
        }
        public Boolean IsUserInRole(Roles role)
        {
            return this._service.IsUserInRole(role);
        }
        public Boolean IsUserHasRights(Rights rights)
        {
            return this._service.IsUserHasRights(rights);
        }
        #endregion

        #region handlers
      
        #endregion
    }
}
