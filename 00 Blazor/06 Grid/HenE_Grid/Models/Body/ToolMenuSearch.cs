// <copyright file="ToolMenuSearch.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Overzichten.Blazor.Models.Body
{
    using HenE.Aeolus.Overzichten.Blazor.Enumeration;

    /// <summary>
    /// Klas waar de properties van een element staat in.
    /// </summary>
    public class ToolMenuSearch : ToolMenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuSearch"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="titel">Titel van een element.</param>
        public ToolMenuSearch(int id, string titel)
            : base(id, titel, ToolType.Search)
        {
        }
    }
}
