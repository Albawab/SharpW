// <copyright file="Bord.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.TestApp
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using HenE.InterfaceCommunicate.Interfaces;

    /// <summary>
    /// Kijken of de set geldig is of niet.
    /// </summary>
    internal class Bord : IBordController
    {
        /// <summary>
        /// Deze method check of het geldig set of niet.
        /// </summary>
        /// <param name="move">De zet.</param>
        /// <returns>true als het geldig is. false als het niet geldig is.</returns>
        public bool IsMoveBetweenBoundaries(int move)
        {
            if (move < 2 || move > 9)
            {
                DateTime time = DateTime.Now.ToLocalTime();
                time.ToString();
                this.Log(time);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Packt de informatie van de project.
        /// </summary>
        /// <param name="time">Tijd.</param>
        // /// <param name="info">Information.</param>
        // /// <param name="iPAddress">IpAddress van de client.</param>
        public void Log(DateTime time)
        {
            string ipAddress = this.GetLocalIPAddress();
            string message = "Het nummer is niet correct " + time.ToString() + "\n" + ipAddress;
            WriteTextFile writeText = new WriteTextFile();
            writeText.WriteText(message);
        }

        /// <summary>
        /// Get the IPAddress.
        /// </summary>
        /// <returns>IpAddress.</returns>
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
