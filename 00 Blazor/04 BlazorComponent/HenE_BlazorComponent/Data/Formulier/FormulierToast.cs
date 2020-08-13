// <copyright file="FormulierToast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using HenE_BlazorComponent.Enumeration;

    public class FormulierToast : FormulierElement
    {
        /// <summary>
        /// Gets of sets de title van de toast.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets de content vna een toast.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets de position van een toast.
        /// </summary>
        public HorizontalAlign XPosition { get; set; }

        /// <summary>
        /// Gets or sets de position van een toast.
        /// </summary>
        public VerticalAlign YPosition { get; set; }
    }
}
