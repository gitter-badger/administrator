using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using ALProjects.Core.Contracts.Interfaces;

namespace ALProjects.Common.AppState
{
    public class WinStateProvider :  IStateProvider
    {
        private static readonly Dictionary<string, Object> dictionary = new Dictionary<string, object>();

        public HttpApplicationState AppState
        {
            get { return HttpContext.Current.Application; }
        }

        public IDictionary<string, Object> SessionState
        {
            get { return dictionary; }
        }
    }
}