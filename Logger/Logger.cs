using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public interface ILogger
    {
        void Log(LogEntry entry);
    }

    public abstract class Logger : ILogger
    {
        public abstract void Log(LogEntry entry);
    }

    public enum LoggingEventType
    {
        Debug,
        Info,
        Warning,
        Error,
        Critical,
    };

    public class LogEntry
    {
        public readonly LoggingEventType loggingEventType;
        public readonly string Message;
        public readonly Exception exception;

        public LogEntry(LoggingEventType severity, string message, Exception exception = null)
        {
            if (message == null) throw new ArgumentNullException("message");
            if (message == string.Empty) throw new ArgumentException("empty", "message");

            this.loggingEventType = severity;
            this.Message = message;
            this.exception = exception;
        }
    }
}
