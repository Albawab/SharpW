// <copyright file="HeaderItemModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Header.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Klas van de header waar de proporties er in staan.
    /// </summary>
    public class HeaderItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderItemModel"/> class.
        /// </summary>
        /// <param name="titel">Het titel van de header.</param>
        public HeaderItemModel(string titel)
        {
            this.Titel = titel;
        }

        /// <summary>
        /// Gets or sets get en set de title van een header.
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Gets or sets de kinderen van de header.
        /// </summary>
        public List<HeaderItemModel> Kinderen { get; set; }
    }
}
