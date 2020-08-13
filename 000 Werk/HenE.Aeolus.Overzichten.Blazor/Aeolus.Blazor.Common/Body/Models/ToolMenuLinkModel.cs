// <copyright file="ToolMenuLink.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Blazor.Common.Body.Models
{

    /// <summary>
    /// Klas waar de properties van een item staat in.
    /// </summary>
    public class ToolMenuLinkModel : ToolMenuItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuLink"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="titel">Titel van een element.</param>
        public ToolMenuLinkModel(int id, string titel)
            : base(id, titel, ToolType.Link)
        {
        }
    }
}
