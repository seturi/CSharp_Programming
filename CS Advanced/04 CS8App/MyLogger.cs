using _04_Common;
using System;
using System.Diagnostics;

namespace _04_CS8App
{
    class MyLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
            Debug.WriteLine(message);
        }

        public void Log(Exception exception)
        {
            Log(exception.ToString());
        }
    }
}
