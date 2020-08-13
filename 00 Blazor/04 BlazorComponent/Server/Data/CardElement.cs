// <copyright file="CardElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using HenE_Server.Enumeration;

namespace HenE_Server.Data
{

    /// <summary>
    /// De basecontroller van de card elementen.
    /// </summary>
    public class CardElement
    {
        /// <summary>
        /// Gets or sets row van de table.
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// Gets or sets kolom van de table.
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Gets or sets aantal rijen dat dit element moet beslaan.
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// Gets or sets aantal Kolommen die dit element moet innemen.
        /// </summary>
        public int Columns { get; set; }

        /// <summary>
        /// Gets or sets de soort van de element.
        /// </summary>
        public SoortCardElementen Soort { get; set; }

        /// <summary>
        /// Gets or sets de horizontal align van een element.
        /// </summary>
        public HorizontalAlign HorizontalAlign { get; set; } = HorizontalAlign.Left;

        /// <summary>
        /// Gets or sets de vertical align van een element.
        /// </summary>
        public VerticalAlign VerticalAlign { get; set; } = VerticalAlign.Center;
    }
}
