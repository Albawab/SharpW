// <copyright file="CardlabelElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using HenE_BlazorComponent.Enumeration;

    /// <summary>
    /// De label element.
    /// </summary>
    public class CardLabelElement : CardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardLabelElement"/> class.
        /// </summary>
        public CardLabelElement() => this.Soort = SoortCardElementen.Label;

        /// <summary>
        /// Gets or sets de title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets de soort van een card.
        /// </summary>
        public CardLabelSoorten Type { get; set; } = CardLabelSoorten.Normaal;
    }
}
