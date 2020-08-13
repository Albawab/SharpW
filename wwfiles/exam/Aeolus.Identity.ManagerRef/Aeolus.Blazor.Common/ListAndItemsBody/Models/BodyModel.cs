// <copyright file="BodyModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models

{
    using System.ComponentModel;

    /// <summary>
    /// Klas waar in de properties van de elementen staat in.
    /// </summary>
    public class BodyModel
    {
        /// <summary>
        /// Gets or sets de id van een item.
        /// </summary>
        [Description("ID")]
        [ModelAttributen(MagTonen =false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets de titel van een item.
        /// </summary>
        [ModelAttributen(MagTonen = false)]
        public string Titel { get; set; }
    }
}
