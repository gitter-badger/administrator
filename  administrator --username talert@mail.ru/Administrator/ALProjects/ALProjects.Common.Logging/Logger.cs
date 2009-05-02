using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Lookups;
using System.IO;
using System.Reflection;
using ALProjects.Core.Config;

namespace ALProjects.Common.Logging
{
    //[System.Diagnostics.DebuggerStepThrough]
    public sealed class Logger : IDisposable
    {
        #region members
        List<ILogWriter> _writers = new List<ILogWriter>();

        private bool disposed = false;
        #endregion

        #region singlation
        static readonly Logger _curent = new Logger();
        public static Logger Instance
        {
            get { return _curent; }
        }
        static Logger() { }
        private Logger() 
        {
            if (!ConfigSettings.Current.Logging.UseLogging)
            {
                return;
            }

            foreach (LogAppender appender in ConfigSettings.Current.Logging.Loggers)
            {
                Type t = Type.GetType(appender.Type);
                if (t != null)
                {
                    ILogWriter logWriter = Activator.CreateInstance(t) as ILogWriter;
                    if (logWriter != null)
                    {
                        logWriter.Initialize(
                            this,
                            appender.LogError,
                            appender.LogWarning,
                            appender.LogMessage);
                        this._writers.Add(logWriter);
                    }
                }
            }
            this.OnStartLoging();
        }
        #endregion

        #region events

        public event LogEventHandler Error;
        public event LogEventHandler Warning;
        public event LogEventHandler Message;
        public event EventHandler StartLogging;
        public event EventHandler StopLogging;
        //  public event LogEventHandler LogAction;
        #endregion

        #region public members

        #region error
        public void LogError(Exception exception, Object sender)
        {
            this.LogError(String.Empty, exception, sender);
        }
        public void LogError(String message, Object sender)
        {
            this.LogError(message, null, sender);
        }
        public void LogError(Exception exception, LogLevels logLevel, Object sender)
        {
            this.LogError(String.Empty, exception, logLevel, sender);
        }
        public void LogError(String message, LogLevels logLevel, Object sender)
        {
            this.LogError(message, null, logLevel, sender);
        }
        public void LogError(String message, Exception exception, Object sender)
        {
            this.LogError(message, exception, LogLevels.Default, sender);
        }
        public void LogError(String message, Exception exception, LogLevels logLevel, Object sender)
        {
            OnError(sender, new LogEventArgs(message, this.getTrueException(exception), logLevel));
        }
        #endregion

        #region warning
        public void LogWarning(Exception exception, Object sender)
        {
            this.LogWarning(String.Empty, exception, sender);
        }
        public void LogWarning(String message, Object sender)
        {
            this.LogWarning(message, null, sender);
        }
        public void LogWarning(Exception exception, LogLevels logLevel, Object sender)
        {
            this.LogWarning(String.Empty, exception, logLevel, sender);
        }
        public void LogWarning(String message, LogLevels logLevel, Object sender)
        {
            this.LogWarning(message, null, logLevel, sender);
        }
        public void LogWarning(String message, Exception exception, Object sender)
        {
            this.LogWarning(message, exception, LogLevels.Default, sender);
        }
        public void LogWarning(String message, Exception exception, LogLevels logLevel, Object sender)
        {
            OnWarning(sender, new LogEventArgs(message, this.getTrueException(exception), logLevel));
        }
        #endregion

        #region message
        public void LogMessage(Exception exception, Object sender)
        {
            this.LogMessage(String.Empty, exception, sender);
        }
        public void LogMessage(String message, Object sender)
        {
            this.LogMessage(message, null, sender);
        }
        public void LogMessage(Exception exception, LogLevels logLevel, Object sender)
        {
            this.LogMessage(String.Empty, exception, logLevel, sender);
        }
        public void LogMessage(String message, LogLevels logLevel, Object sender)
        {
            this.LogMessage(message, null, logLevel, sender);
        }
        public void LogMessage(String message, Exception exception, Object sender)
        {
            this.LogMessage(message, exception, LogLevels.Default, sender);
        }
        public void LogMessage(String message, Exception exception, LogLevels logLevel, Object sender)
        {
            OnMessage(sender, new LogEventArgs(message, this.getTrueException(exception), logLevel));
        }
        #endregion

        #endregion

        #region private methods
        private void OnError(Object sender, LogEventArgs e)
        {
            if (this.Error != null)
            {
                Error(sender ?? this, e);
            }
        }
        private void OnWarning(Object sender, LogEventArgs e)
        {
            if (this.Warning != null)
            {
                Warning(sender ?? this, e);
            }
        }
        private void OnMessage(Object sender, LogEventArgs e)
        {
            if (this.Message != null)
            {
                Message(sender ?? this, e);
            }
        }
        private void OnStartLoging()
        {
            if (this.StartLogging != null)
            {
                StartLogging(this, EventArgs.Empty);
            }
        }
        private void OnStopLogging()
        {
            if (this.StopLogging != null)
            {
                StopLogging(this, EventArgs.Empty);
            }
        }

        private void loadWriters()
        {
        }

        #region halpers
        private Exception getTrueException(Exception ex)
        {
            if (ex == null) return null;

            if (ex.InnerException != null)
            {
                return this.getTrueException(ex);
            }
            else
            {
                return ex;
            }
        }
        #endregion

        #endregion

        #region IDisposable Members
        ~Logger()
        {
            Dispose();
        }

        public void Dispose()
        {
           
            this.Dispose(this.disposed);
        }

        private void Dispose(Boolean disposed)
        {
            if (!disposed)
            {
                this.OnStopLogging();

                foreach (ILogWriter writer in this._writers)
                {
                    writer.Dispose();
                }

                this.disposed = true;
            }
        }

        #endregion
    }

    public delegate void LogEventHandler(Object sender, LogEventArgs e);
    public class LogEventArgs : EventArgs
    {
        #region members
        private String _message;
        private Exception _exception;
        private LogLevels _logLevel;
        #endregion

        public  LogEventArgs(String message, Exception exception, LogLevels logLevel)
        {
            this._message = message;
            this._exception = exception;
            this._logLevel = logLevel;
        }

        #region public properties
        public String message
        {
            get { return this._message; }
        }
        public Exception exception
        {
            get { return this._exception; }
        }
        public LogLevels logLevel
        {
            get { return this._logLevel; }
        }
        #endregion
    }
}
