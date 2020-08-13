// <copyright file="DialogButtonModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Klas van een tool menu knop waar de properties van de knop staat.
    /// </summary>
    public class DialogButtonModel : MenubarItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogButtonModel"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="title">Titel van een element.</param>
        public DialogButtonModel(int id, string title)
            : base(id, title, MenubarType.DialogButton)
        {
        }
    }
}