// <copyright file="MenubarButtonModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Klas van een tool menu knop waar de properties van de knop staat.
    /// </summary>
    public class MenubarButtonModel : MenubarItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenubarButtonModel"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="title">Titel van een element.</param>
        public MenubarButtonModel(int id, string title)
            : base(id, title, MenubarType.Button)
        {
        }
    }
}
