// <copyright file="FormulierSpecificatie.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using System.Collections.Generic;
    using HenE_BlazorComponent.Enumeration;

    /// <summary>
    /// De specificatie van een formulier.
    /// </summary>
    public class FormulierSpecificatie : FormulierElement
    {
        /// <summary>
        /// Gets or sets de soort van de specificatie.
        /// </summary>
        public SpecificatieSoort SpecificatieSoort { get; set; }

        /// <summary>
        /// Gets or sets de groote van de specificatie.
        /// </summary>
        public SpecificatieSize SpecificatieSize { get; set; }

        /// <summary>
        /// Gets or sets de emlementen van een specificatie.
        /// </summary>
        public List<FormulierElement> Elements { get; set; }

        /// <summary>
        /// Gets or sets een kind.
        /// </summary>
        public KinderFormulier Kinder { get; set; }
    }
}
