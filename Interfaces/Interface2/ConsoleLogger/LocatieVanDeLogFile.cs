using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loggers
{
    public class StandaardSettings : ITellLocationOfLogFile
    {
        /// <summary>
        /// Vertelt waar is de location.
        /// </summary>
        public string LocationOfLogFile()
        {
            return "c:\\tmp\\log2.txt";
        }
    }
}
