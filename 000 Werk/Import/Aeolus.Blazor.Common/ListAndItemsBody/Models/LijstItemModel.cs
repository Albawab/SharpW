// <copyright file="LijstItemModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models
{
    using System;

    /// <summary>
    /// klas waar de proporties van de lijst model staat in.
    /// </summary>
    public class LijstItemModel : LijstItemsModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LijstItemModel"/> class.
        /// </summary>
        /// <param name="id">De id van een item.</param>
        /// <param name="titel">Het titel van een item.</param>
        /// <param name="omschrijving">De omschrijving van een items.</param>
        public LijstItemModel(int id, string titel, string omschrijving)
            : base(titel)
        {
            this.Omschrijving = omschrijving;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets de onschrijving.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// Gets or sets de datetime van een element.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets de uri van een element.
        /// </summary>
        public string Uri { get; set; }
    }
}