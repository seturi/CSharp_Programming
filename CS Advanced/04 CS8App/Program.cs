using _04_Common;
using System;

namespace _04_CS8App
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger myLogger = new MyLogger();
            myLogger.Log("Test message");
            myLogger.Log(new ApplicationException("err"));
            myLogger.Log("Error", "test error");
        }
    }
}
