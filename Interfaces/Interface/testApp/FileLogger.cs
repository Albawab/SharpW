// <copyright file="FileLogger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.TestApp
{
    using System.IO;
    using HenE.InterfaceCommunicate.Interfaces;

    public class FileLogger : ILogger
    {
        /// <inheritdoc/>
        public void Log(string informatie)
        {
            File.WriteAllText("c:\\tmp\\log.txt", informatie);
        }

        public void print()
        {
            System.Console.WriteLine("Hallo");
        }
    }
}
