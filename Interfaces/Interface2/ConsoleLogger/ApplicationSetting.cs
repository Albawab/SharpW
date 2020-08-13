namespace Loggers
{
    using Interfaces;
    using System;
    using System.IO;

    public class ApplicationSetting : ITellLocationOfLogFile
    {

        /// <summary>
        /// Get de location of de project.
        /// </summary>
        /// <returns>Location van de HuidigMap</returns>
        public string LocationOfLogFile()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string locatie = projectDirectory + "\\log3.txt";
            return locatie;

        }
    }
}
