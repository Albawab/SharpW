using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Loggers
{
    public class FileLogger : ILog
    {
        private readonly ITellLocationOfLogFile locationOfLogFileTeller;

        public FileLogger(ITellLocationOfLogFile locationOfLogFileTeller)
        {
            this.locationOfLogFileTeller = locationOfLogFileTeller;
        }

        public void Log(string information)
        {
            File.WriteAllText(locationOfLogFileTeller?.LocationOfLogFile(), information);
        }
    }

}
