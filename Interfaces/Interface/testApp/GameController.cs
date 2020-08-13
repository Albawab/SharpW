// <copyright file="GameController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.TestApp
{
    using System;
    using HenE.ConsoleCommunicate;
    using HenE.InterfaceCommunicate.Interfaces;

    /// <summary>
    /// Control of de set goed is of niet.
    /// </summary>
    public class GameController
    {
        private readonly IBordController bordController;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameController"/> class.
        /// </summary>
        /// <param name="bordController">Bord Controller.</param>
        public GameController(IBordController bordController)
        {
            this.bordController = bordController;
        }

        /// <summary>
        /// Start om de zet te controleren.
        /// </summary>
        public void Start()
        {
            Persoon persoonA = new Persoon(new ConsoleCommunicate());

            int preferredMove = persoonA.PreferredMove();

            // If the move is not valid. Return it , and ask the player for a new move.
            while (!this.bordController.IsMoveBetweenBoundaries(preferredMove))
            {
                persoonA.Tell("De invoer is niet ok, probeer het opnieuw");
                preferredMove = persoonA.PreferredMove();
            }
        }

        /// <summary>
        /// Packt de informatie van de project.
        /// </summary>
        /// <param name="time">Tijd.</param>
        // /// <param name="info">Information.</param>
        // /// <param name="iPAddress">IpAddress van de client.</param>
        public void Log(DateTime time)
        {
            string message = time.ToString();
            WriteTextFile writeText = new WriteTextFile();
            writeText.WriteText(message.ToString());
        }
    }
}
