namespace HenE.TestApp
{
    using System;
    using HenE.InterfaceCommunicate.Interfaces;

    public class ConsoleLogger : ILogger
    {
        /// <inheritdoc/>
        public void Log(string informatie)
        {
            Console.WriteLine(informatie);
        }
    }
}
