// <copyright file="ApiModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Api.Models
{
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

    /// <summary>
    /// Klas waar de properties van api model staan in.
    /// </summary>
    public class ApiModel : BodyModel
    {
        /// <summary>
        /// Gets or sets de omschrijving van een item.
        /// </summary>
        [ModelAttributen(Order = 1)]
        public string Omschrijving { get; set; }
    }
}
