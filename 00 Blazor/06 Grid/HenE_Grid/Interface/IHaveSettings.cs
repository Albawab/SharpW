// <copyright file="IHaveSettings.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Overzichten.Blazor.Interface
{
    using HenE.Aeolus.Overzichten.Blazor.Settings;

    /// <summary>
    /// Interface waarin de instellingen van de applicatie staan.
    /// </summary>
    public interface IHaveSettings
    {
        /// <summary>
        /// Gets de instellingen van de applicatie.
        /// </summary>
        /// <returns>De instellingen van de applicatie.</returns>
        Instellingen GetInstellingen();
    }
}
