// <copyright file="FormulierVraag.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// De eigenschappen van een vraag.
    /// </summary>
    public class FormulierVraag : FormulierElement
    {
        /// <summary>
        /// Gets or sets de text van een element.
        /// </summary>
        public string Text { get; set; }

        public FormulierTooltip Tooltip { get; set; }

        /// <summary>
        /// Gets or sets de antwoorden van de vraag.
        /// </summary>
        public List<FormulierAntwoord> Antwoorden { get; set; }
    }
}