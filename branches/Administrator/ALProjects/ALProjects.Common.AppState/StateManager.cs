using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using ALProjects.Core.Config;
using ALProjects.Core.Contracts.Interfaces;
using ALProjects.Core.Lookups;

namespace ALProjects.Common.AppState
{
    public class StateManager
    {
        #region singlation

        private static readonly StateManager _current = new StateManager();

        private StateManager()
        {
            var appType =
                (ApplicationTypes) Enum.Parse(typeof (ApplicationTypes), Settings.Default.ApplicationType);
            switch (appType)
            {
                case ApplicationTypes.Win:
                    _stateProvider = new WinStateProvider();
                    break;
                case ApplicationTypes.Web:
                    _stateProvider = new WebStateProvider();
                    break;
            }
        }

        public static StateManager Current
        {
            get { return _current; }
        }

        #endregion

        #region members

        private readonly IStateProvider _stateProvider;

        #endregion

        #region public properties

        public HttpApplicationState Application
        {
            get { return _stateProvider.AppState; }
        }

        public IDictionary<string, Object> Session
        {
            get { return _stateProvider.SessionState; }
        }

        #endregion
    }
}