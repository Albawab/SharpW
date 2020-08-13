// <copyright file="ApiModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Api.Models
{
    using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Models;

    /// <summary>
    /// Klas waar de properties van api model staan in.
    /// </summary>
    public class ApiModel : BodyModel
    {
        /// <summary>
        /// Gets or sets de omschrijving van een item.
        /// </summary>
        public string Omschrijving { get; set; }
    }
}
