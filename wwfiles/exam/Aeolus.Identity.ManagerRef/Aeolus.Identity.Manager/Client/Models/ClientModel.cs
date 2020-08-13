// <copyright file="ClientModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Client.Models
{
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

    /// <summary>
    /// Klas waar de properties van de een item staat in.
    /// </summary>
    public class ClientModel : BodyModel
    {
        /// <summary>
        /// Gets or sets de name van een client.
        /// </summary>
        [ModelAttributen(Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets de Ip van een client.
        /// </summary>
        [ModelAttributen(Order = 2)]
        public string IP { get; set; }
    }
}
