// <copyright file="KinderFormulier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    using System;

    /// <summary>
    /// De gegevens van een kinder.
    /// </summary>
    public class KinderFormulier
    {
        /// <summary>
        /// Gets or sets de eerste naam van een kind.
        /// </summary>
        public string EersteNaam { get; set; }

        /// <summary>
        /// Gets or sets het voor letter van een kind.
        /// </summary>
        public string Voorletter { get; set; }

        /// <summary>
        /// Gets or sets de achter naam van een kind.
        /// </summary>
        public string AchterNaam { get; set; }

        /// <summary>
        /// Gets or sets de geboortedatum van een kind.
        /// </summary>
        public DateTime GeboorteDatum { get; set; }
    }
}
