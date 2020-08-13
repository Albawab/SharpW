// <copyright file="InstellingenDataBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Setting
{
    using HenE_BlazorComponent.Interface;

    /// <summary>
    /// Haalt de gegevens van uit de database.
    /// </summary>
    public class InstellingenDataBase : IHaveSettings
    {
        /// <summary>
        /// Geeft de data terug die uit de database gehaald.
        /// </summary>
        /// <returns>De nieuwe main instellingen.</returns>
        public Instellingen GetInstellingen()
        {
            var testInstellingen = new Instellingen();
            testInstellingen.TimerTextAreaDataOpslaanMS = "3000";
            return testInstellingen;
        }
    }
}
