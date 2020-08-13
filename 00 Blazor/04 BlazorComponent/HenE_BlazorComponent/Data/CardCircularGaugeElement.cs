// <copyright file="CardCircularGaugeElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    /// <summary>
    /// de card circular gauge element.
    /// </summary>
    public class CardCircularGaugeElement : CardElement
    {
        /// <summary>
        /// Gets or sets start van de circular gauge.
        /// </summary>
        public int StartAngle { get; set; }

        /// <summary>
        /// Gets or sets eind van de circular gauge.
        /// </summary>
        public int EndAngle { get; set; }

        /// <summary>
        /// Gets or sets De value van de circular gauge.
        /// </summary>
        public int Value { get; set; }
    }
}
