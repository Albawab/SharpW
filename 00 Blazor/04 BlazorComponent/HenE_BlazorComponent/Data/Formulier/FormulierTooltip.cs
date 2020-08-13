// <copyright file="FormulierTooltip.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using HenE_BlazorComponent.Enumeration;

    public class FormulierTooltip : FormulierElement
    {
        /// <summary>
        /// Gets or sets the content of tooltip.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the position of tooltip.
        /// </summary>
        public TooltipPosition Position { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets. show the tip pointer.
        /// </summary>
        public bool ShowTipPointer { get; set; }
    }
}
