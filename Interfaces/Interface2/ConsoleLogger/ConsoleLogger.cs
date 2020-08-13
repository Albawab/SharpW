using Interfaces;
using System;

namespace Loggers
{
    public class ConsoleLogger : ILog
    {
        public void Log(string information)
        {
            Console.WriteLine(information);
        }
    }
}
