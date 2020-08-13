// <copyright file="FormulierSectie.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    using System.Collections.Generic;
    using HenE_Server.Enumeration;

    /// <summary>
    /// De klas van een sectio van de belasting.
    /// </summary>
    public class FormulierSectie : FormulierElement
    {
        /// <summary>
        /// Gets or sets de horizontal align van een element.
        /// </summary>
        public HorizontalAlign HorizontalAlign { get; set; } = HorizontalAlign.Left;

        /// <summary>
        /// Gets or sets de vertical align van een element.
        /// </summary>
        public VerticalAlign VerticalAlign { get; set; } = VerticalAlign.Center;

        /// <summary>
        /// Gets or sets de nummer van de section.
        /// </summary>
        public int SectionNumber { get; set; }

        /// <summary>
        /// Gets or sets toelichting van een section.
        /// </summary>
        public string Toelichting { get; set; }

        /// <summary>
        /// Gets or sets de title van de section.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets de kinderen van een section.
        /// </summary>
        public List<FormulierElement> SectionKinderen { get; set; }

        /// <summary>
        /// Gets or sets de soort van een card.
        /// </summary>
        public CardLabelSoorten Type { get; set; } = CardLabelSoorten.Normaal;
    }
}
