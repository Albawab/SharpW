// <copyright file="ILogger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.InterfaceCommunicate.Interfaces
{
    using System;
    using System.Net;

    /// <summary>
    /// Interface die gebruikt worden voor het informatie. Informatie van de project.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Packt de informatie van de project.
        /// </summary>
        /// <param name="time">Tijd.</param>
        /*  /// <param name="time">Tijd.</param>
        /// <param name="iPAddress">IpAddress van de client.</param>
        /// */
        void Log(string informatie);
    }
}
