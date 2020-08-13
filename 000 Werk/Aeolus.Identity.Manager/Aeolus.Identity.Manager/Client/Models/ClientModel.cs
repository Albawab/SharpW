// <copyright file="ClientModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Client.Models
{
    using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Models;

    /// <summary>
    /// Klas waar de properties van de een item staat in.
    /// </summary>
    public class ClientModel : BodyModel
    {
        /// <summary>
        /// Gets or sets de name van een client.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets de Ip van een client.
        /// </summary>
        public string IP { get; set; }
    }
}
