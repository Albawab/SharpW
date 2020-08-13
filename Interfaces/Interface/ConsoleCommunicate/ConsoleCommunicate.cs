// <copyright file="ConsoleCommunicate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.ConsoleCommunicate
{
    using System;
    using HenE.Communicator.Interfaces;
    using HenE.InterfaceCommunicate.Interfaces;

    /// <summary>
    /// Stuur een bericht en krijg antwoord van de persoon.
    /// </summary>
    public class ConsoleCommunicate : ICanCommunicate, ILogger
    {
        /// <summary>
        /// Functie om een vraag te stellen en een antwoord te krijgen.
        /// </summary>
        /// <param name="question">de vraag dit gesteld gaat worden.</param>
        /// <returns>Het antwoord van de vraag.</returns>
        public string Ask(string question)
        {
            Console.WriteLine(question);
            DateTime time = DateTime.Now.ToLocalTime();
            time.ToString();
            //this.Log(time);
            return Console.ReadLine();
        }

        /// <summary>
        /// Functie om een partij een melding te geven.
        /// </summary>
        /// <param name="message">de melding die verstuurt gaat worden.</param>
        public void Tell(string message)
        {
            DateTime time = DateTime.Now.ToLocalTime();
            time.ToString();
            Console.WriteLine(message);
        }

        /// <summary>
        /// Packt de informatie van de project.
        /// </summary>
        /// <param name="time">Tijd.</param>
        // /// <param name="info">Information.</param>
        // /// <param name="iPAddress">IpAddress van de client.</param>
        public void Log(string information)
        {
            // Method intentionally left empty.
        }
    }
}
