// <copyright file="CardDateElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using System;

    /// <summary>
    /// De card date element.
    /// </summary>
    public class CardDateElement : CardElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDateElement"/> class.
        /// </summary>
        public CardDateElement() => this.Soort = SoortCardElementen.Date;

        /// <summary>
        /// Gets or sets Data van een card.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets Start datum.
        /// </summary>
        public DateTime MinDate { get; set; }

        /// <summary>
        /// Gets or sets End datum.
        /// </summary>
        public DateTime MaxDate { get; set; }
    }
}
