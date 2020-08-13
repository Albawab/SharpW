// <copyright file="ButtonAnimationEffect.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Enumeration
{
    /// <summary>
    /// Waar de effect van een button staat.
    /// </summary>
    public enum ButtonAnimationEffect
    {
        /// <summary>
        /// De spin in de button wordt groter.
        /// </summary>
        ZoomOut,

        /// <summary>
        /// De spin in de button wordt Kleiner.
        /// </summary>
        ZoomIn,

        /// <summary>
        /// De spin in de button gaat van de linkskant starten.
        /// </summary>
        SlideLeft,

        /// <summary>
        /// De spin in de button gaat van de richtskant starten.
        /// </summary>
        SlideRight,
    }
}
