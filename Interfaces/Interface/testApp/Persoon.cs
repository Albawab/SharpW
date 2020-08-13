// <copyright file="Persoon.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.TestApp
{
    using HenE.Communicator.Interfaces;

    /// <summary>
    /// Contact met de speler.
    /// </summary>
    public class Persoon
    {
        private readonly ICanCommunicate communicator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Persoon"/> class.
        /// </summary>
        /// <param name="communicator">Communicator.</param>
        public Persoon(ICanCommunicate communicator)
        {
            this.communicator = communicator;
        }

        /// <summary>
        /// welke set zou de persoon willen doen.
        /// </summary>
        /// <returns>Het nummer als string.</returns>
        public int PreferredMove()
        {
            int result = 0;

            string answer = this.communicator.Ask("Welke zet wilt u doen?");

            int.TryParse(answer, out result);

            return result;
        }

        /// <summary>
        /// Een bericht naar de persoon sturen.
        /// </summary>
        /// <param name="message">De bericht die naar de speler moet sturn.</param>
        public void Tell(string message)
        {
            this.communicator.Tell(message);
        }
    }
}
