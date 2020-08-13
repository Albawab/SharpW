// <copyright file="FormulierAntwoord.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    /// <summary>
    /// De eigenschappen van de antwoord.
    /// </summary>
    public class FormulierAntwoord : FormulierElement
    {
        /// <summary>
        /// Gets or sets de soort van een antwoord.
        /// </summary>
        public SoortAntwoord SoortAntwoord { get; set; }

        /// <summary>
        /// Gets or sets toelichting van een antwoord.
        /// </summary>
        public string AntwoordToelichting { get; set; }
    }
}