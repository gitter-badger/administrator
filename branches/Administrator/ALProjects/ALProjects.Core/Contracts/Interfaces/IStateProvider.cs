using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace ALProjects.Core.Contracts.Interfaces
{
    public interface IStateProvider
    {
        HttpApplicationState AppState { get; }
        IDictionary<string,object> SessionState { get; }
    }
}
