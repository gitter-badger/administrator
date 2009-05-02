using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Lookups;
using System.IO;
using ALProjects.Core.Config;

namespace ALProjects.Common.Logging.LogWriters
{
    [System.Diagnostics.DebuggerStepThrough]
    public class BaseLogWriter : ILogWriter
    {
        #region members

        protected String _logFile;
        protected String _logDir;
        protected Logger _logger;
        protected Boolean _logEroor;
        protected Boolean _logWarning;
        protected Boolean _logMessage;

        protected Boolean disposed = false;
        #endregion

        #region ctors
        public BaseLogWriter()
        {
           
            this._logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            this._logFile = Path.Combine(this._logDir,
                String.Format("log_{0}_{1}_{2}.txt",DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day));
            if(!Directory.Exists( this._logDir))
            {
                Directory.CreateDirectory(this._logDir);
            }
        }
        #endregion 

        #region hendlerss
        
        private void _logger_StartLogging(object sender, EventArgs e)
        {
            if (this._logEroor)
            {
                this._logger.Error += new LogEventHandler(_logger_Error);
            }
            if (this._logWarning)
            {
                this._logger.Warning += new LogEventHandler(_logger_Warning);
            }
            if (this._logMessage)
            {
                this._logger.Message += new LogEventHandler(_logger_Message);
            }
        }

        private void _logger_Message(object sender, LogEventArgs e)
        {
            this.WriteMessage(buildMessage(sender, e));
        }

        private void _logger_Warning(object sender, LogEventArgs e)
        {
            this.WriteWarning(buildMessage(sender, e));
        }
        private void _logger_StopLogging(object sender, EventArgs e)
        {
            this._logger.Error -= new LogEventHandler(_logger_Error);
            this._logger.Warning -= new LogEventHandler(_logger_Warning);
            this._logger.Message -= new LogEventHandler(_logger_Message);
        }

        private void _logger_Error(object sender, LogEventArgs e)
        {
            //if ((e.logLevel & this.GetLogLevel) == 0) return;

            this.WriteError(buildMessage(sender,e));
        }
        #endregion

        #region private methods
        private String buildMessage(object sender, LogEventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            if (!String.IsNullOrEmpty(e.message))
            {
                msg.Append("'");
                msg.Append(e.message);
                msg.Append("' ");
            }
            if (e.exception != null)
            {
                msg.Append("| ");
                msg.Append(e.exception.ToString());
             }
            if (sender != null)
            {
                msg.Append(" | Sender [");
                msg.Append(sender.ToString());
                msg.Append("] ");
            }
            return msg.ToString();
        }
        #endregion

        #region ILogWriter Members

        public void Initialize(Logger logger, Boolean logError, Boolean logWarning, Boolean logMessage)
        {
            this._logger = logger;
            this._logEroor = logError;
            this._logWarning = logWarning;
            this._logMessage = logMessage;
            this._logger.StartLogging += new EventHandler(_logger_StartLogging);
            this._logger.StopLogging += new EventHandler(_logger_StopLogging);  
        }

        public virtual LogLevels GetLogLevel
        {
            get { return LogLevels.Default; }
        }

        public virtual void WriteError(String msg)
        {
            using (StreamWriter writer = new StreamWriter(this._logFile, true))
            {
                msg = String.Format("{0} | Error : {1}", DateTime.Now, msg);
                writer.WriteLine(msg);
            }
        }

        public virtual void WriteWarning(String msg)
        {
            using (StreamWriter writer = new StreamWriter(this._logFile, true))
            {
                msg = String.Format("{0} | Warning : {1}", DateTime.Now, msg);
                writer.WriteLine(msg);
            }
        }

        public virtual void WriteMessage(String msg)
        {
            using (StreamWriter writer = new StreamWriter(this._logFile, true))
            {
                msg = String.Format("{0} | {1}", DateTime.Now, msg);
                writer.WriteLine(msg);
            }
        }

        #endregion

        #region IDisposable Members

        ~BaseLogWriter()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(this.disposed);
        }

        private void Dispose(Boolean disposed)
        {
            if (!disposed)
            {
                this._logger.StartLogging -= _logger_StartLogging;
                this._logger.StopLogging -= _logger_StopLogging;

                disposed = true;
            }
        }
        #endregion
    }
}
