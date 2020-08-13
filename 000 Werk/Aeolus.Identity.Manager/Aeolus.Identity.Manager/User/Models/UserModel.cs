// <copyright file="UserModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.User.Models
{
    using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Models;

    /// <summary>
    /// Klas waar de properties van een item staat in.
    /// </summary>
    public class UserModel : BodyModel
    {
        /// <summary>
        /// Gets or sets het address van een user.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets de naam van een user.
        /// </summary>
        public string Name { get; set; }
    }
}
