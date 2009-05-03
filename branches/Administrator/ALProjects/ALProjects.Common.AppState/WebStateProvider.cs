using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Contracts.Interfaces;
using System.Web;
using System.Web.SessionState;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace ALProjects.Common.AppState
{
    public class WebStateProvider : IStateProvider
    {
        private const string currentDict = "CURRENT_DICTIONARY";

        public WebStateProvider()
        {
            HttpContext.Current.Session[currentDict] = new Dictionary<string, Object>();
        }

        #region IStateProvider Members

        public HttpApplicationState AppState
        {
            get { return HttpContext.Current.Application; }
        }

        public IDictionary<string,Object> SessionState
        {
            get { return HttpContext.Current.Session[currentDict] as Dictionary<string, Object>; }
        }

        #endregion

        
    }
}
