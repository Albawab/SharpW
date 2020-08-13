// <copyright file="WebSocketCommunicate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebSocketCommunicate
{
    using HenE.Communicator.Interfaces;

    /// <summary>
    /// contect tussen server en de client.
    /// </summary>
    public class WebSocketCommunicate : ICanCommunicate
    {
        /// <summary>
        /// Functie om een vraag te stellen en een antwoord te krijgen.
        /// </summary>
        /// <param name="question">de vraag dit gesteld gaat worden.</param>
        /// <returns>Het antwoord van de vraag.</returns>
        public string Ask(string question)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Functie om een partij een melding te geven.
        /// </summary>
        /// <param name="message">de melding die verstuurt gaat worden.</param>
        public void Tell(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
