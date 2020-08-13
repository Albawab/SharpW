// <copyright file="ToolMenuButton.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Blazor.Common.Body.Models
{

    /// <summary>
    /// Klas van een tool menu knop waar de properties van de knop staat.
    /// </summary>
    public class ToolMenuButtonModel : ToolMenuItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuButtonModel"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="title">Titel van een element.</param>
        public ToolMenuButtonModel(int id, string title)
            : base(id, title, ToolType.Button)
        {
        }
    }
}
