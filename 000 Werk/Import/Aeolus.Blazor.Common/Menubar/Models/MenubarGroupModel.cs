// <copyright file="MenubarGroupModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Klas waar de properties van een item groep staat in.
    /// </summary>
    public class MenubarGroupModel : MenubarItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenubarGroupModel"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="titel">titel van een element.</param>
        public MenubarGroupModel(int id, string titel)
            : base(id, titel, MenubarType.Group)
        {
        }
    }
}
