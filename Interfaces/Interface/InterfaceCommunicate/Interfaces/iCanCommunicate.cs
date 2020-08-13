// <copyright file="iCanCommunicate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Communicator.Interfaces
{
    /// <summary>
    /// interface die gebruikt wordt voor het communiceren, tussen partijen.
    /// </summary>
    public interface ICanCommunicate
    {
        /// <summary>
        /// Functie om een vraag te stellen en een antwoord te krijgen.
        /// </summary>
        /// <param name="question">de vraag dit gesteld gaat worden.</param>
        /// <returns>Het antwoord van de vraag.</returns>
        string Ask(string question);

        /// <summary>
        /// Functie om een partij een melding te geven.
        /// </summary>
        /// <param name="message">de melding die verstuurt gaat worden.</param>
        void Tell(string message);
    }
}
