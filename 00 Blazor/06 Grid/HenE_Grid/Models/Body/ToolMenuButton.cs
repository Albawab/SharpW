// <copyright file="ToolMenuButton.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Overzichten.Blazor.Models.Body
{
    using HenE.Aeolus.Overzichten.Blazor.Enumeration;

    /// <summary>
    /// Klas van een tool menu knop waar de properties van de knop staat.
    /// </summary>
    public class ToolMenuButton : ToolMenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuButton"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="title">Titel van een element.</param>
        public ToolMenuButton(int id, string title)
            : base(id, title, ToolType.Button)
        {
        }
    }
}
