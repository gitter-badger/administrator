using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Lookups;

namespace ALProjects.Common.Logging
{
    public interface ILogWriter : IDisposable
    {
        void Initialize(Logger logger, Boolean logError, Boolean logWarning, Boolean logMessage);

        LogLevels GetLogLevel { get; }

        void WriteError(String msg);

        void WriteWarning(String msg);

        void WriteMessage(String msg);
    }
}
