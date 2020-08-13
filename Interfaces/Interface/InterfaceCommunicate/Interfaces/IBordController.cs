// <copyright file="IBordController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.InterfaceCommunicate.Interfaces
{
    /// <summary>
    /// interface die gebruikt wordt voor het controller, tussen grenzen.
    /// </summary>
    public interface IBordController
    {
        /// <summary>
        /// Check of deze set tussen grenzen.
        /// </summary>
        /// <param name="move">De set die heeft gekozen.</param>
        /// <returns>True als het geldig is. False als het niet geldig is.</returns>
        bool IsMoveBetweenBoundaries(int move);
    }
}
