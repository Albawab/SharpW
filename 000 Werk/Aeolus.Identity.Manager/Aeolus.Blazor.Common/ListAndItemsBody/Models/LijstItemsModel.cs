// <copyright file="LijstItemsModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Klas waar in de properties van de lijst model staan.
    /// </summary>
    public class LijstItemsModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LijstItemsModel"/> class.
        /// </summary>
        /// <param name="titel">De titel van een lijst model.</param>
        public LijstItemsModel(string titel)
        {
            this.Titel = titel;
        }

        /// <summary>
        /// Gets or sets de id van een lijst items.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets de titel van een lijst items.
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Gets or sets de kinderen van een lijst items.
        /// </summary>
        public List<LijstItemsModel> Kinderen { get; set; }
    }
}
