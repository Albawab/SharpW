// <copyright file="ToolMenuSearch.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Blazor.Common.Body.Models
{

    /// <summary>
    /// Klas waar de properties van een element staat in.
    /// </summary>
    public class ToolMenuSearchModel : ToolMenuItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuSearchModel"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="titel">Titel van een element.</param>
        public ToolMenuSearchModel(int id, string titel)
            : base(id, titel, ToolType.Search)
        {
        }
    }
}
