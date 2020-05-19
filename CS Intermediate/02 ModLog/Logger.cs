using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModLog
{
    public class Logger
    {
        // 필드
        private string logDirectory;
        private string logFilename;

        public Logger()
        {
            logDirectory = Environment.CurrentDirectory;
            logFilename = "log.txt";
        }
        public string LogDirectory { get { return logDirectory; } }

        // 메서드
        public void LogSuccess(string msg)
        {

        }

        void LogError(string msg)
        {

        }
    }
}
