// <copyright file="FormulierElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    /// <summary>
    /// De gegevens van de formulier element.
    /// </summary>
    public class FormulierElement
    {
        /// <summary>
        /// Gets or sets de rij van de element.
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// Gets or sets de rijen van de element.
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// Gets or sets de kolom van de element.
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Gets or sets de kolomen van de element.
        /// </summary>
        public int Columns { get; set; }
    }
}
