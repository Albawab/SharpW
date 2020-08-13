// <copyright file="MenubarDialogModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Klas waar in de properties van de dialog staan.
    /// </summary>
    public class MenubarDialogModel : MenubarItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenubarDialogModel"/> class.
        /// </summary>
        /// <param name="id">De id van de dialog box.</param>
        /// <param name="titel">De titel van de dialog box.</param>
        public MenubarDialogModel(int id, string titel)
            : base(id, titel, MenubarType.Dialog)
        {
        }

        /// <summary>
        /// Gets or sets de kinderen van de dialogmedel.
        /// </summary>
        public List<MenubarItemModel> Kinderen { get; set; }
    }
}
