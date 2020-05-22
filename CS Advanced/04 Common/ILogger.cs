using System;

namespace _04_Common
{
    public interface ILogger
    {
        // ILogger v2.0
        void Log(string message);
        void Log(Exception exception)
        {
            Log(exception.Message);
        }

        void Log(string logType, string message)
        {
            if(logType == "Error" ||
                logType == "Warning" ||
                logType == "Info")
            {
                Log($"{logType}:{message}");
            }
            else
            {
                throw new ApplicationException("Invalid LogType");
            }
        }
    }
}
