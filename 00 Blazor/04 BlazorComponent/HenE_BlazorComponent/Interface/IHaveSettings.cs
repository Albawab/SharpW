// <copyright file="IHaveSettings.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#nullable disable
namespace HenE_BlazorComponent.Interface
{
    using HenE_BlazorComponent.Setting;

    /// <summary>
    /// Interface waarin de instellingen van de applicatie staan.
    /// </summary>
    public interface IHaveSettings
    {
        /// <summary>
        /// Get de instellingen.
        /// </summary>
        /// <returns>De instellingen.</returns>
        public Instellingen GetInstellingen();
    }
}
