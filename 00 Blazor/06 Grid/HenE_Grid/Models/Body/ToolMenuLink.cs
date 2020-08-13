// <copyright file="ToolMenuLink.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Overzichten.Blazor.Models.Body
{
    using HenE.Aeolus.Overzichten.Blazor.Enumeration;

    /// <summary>
    /// Klas waar de properties van een item staat in.
    /// </summary>
    public class ToolMenuLink : ToolMenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuLink"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="titel">Titel van een element.</param>
        public ToolMenuLink(int id, string titel)
            : base(id, titel, ToolType.Link)
        {
        }
    }
}
