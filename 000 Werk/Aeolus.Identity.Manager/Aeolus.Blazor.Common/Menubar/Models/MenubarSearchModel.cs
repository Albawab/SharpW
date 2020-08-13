// <copyright file="MenubarSearchModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Klas waar de properties van een element staat in.
    /// </summary>
    public class MenubarSearchModel : MenubarItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenubarSearchModel"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="titel">Titel van een element.</param>
        public MenubarSearchModel(int id, string titel)
            : base(id, titel, MenubarType.Search)
        {
        }
    }
}
