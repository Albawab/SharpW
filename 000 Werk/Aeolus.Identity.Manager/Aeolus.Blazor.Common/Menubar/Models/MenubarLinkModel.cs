// <copyright file="MenubarLinkModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Klas waar de properties van een item staat in.
    /// </summary>
    public class MenubarLinkModel : MenubarItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenubarLinkModel"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="titel">Titel van een element.</param>
        public MenubarLinkModel(int id, string titel)
            : base(id, titel, MenubarType.Link)
        {
        }
    }
}
