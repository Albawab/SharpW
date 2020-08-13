// <copyright file="ApiModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Body.Models
{
    using System;

    /// <summary>
    /// Attribute om de property op een plek te regelen.
    /// </summary>
    public class ModelAttributen : Attribute
    {
        /// <summary>
        /// Gets or sets op een order staat de property.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets of de property mag zien.
        /// </summary>
        public bool MagTonen { get; set; } = true;
    }
}