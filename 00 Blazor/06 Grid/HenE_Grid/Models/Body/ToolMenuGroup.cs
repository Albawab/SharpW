// <copyright file="ToolMenuGroup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Overzichten.Blazor.Models.Body
{
    using HenE.Aeolus.Overzichten.Blazor.Enumeration;

    /// <summary>
    /// Klas waar de properties van een item groep staat in.
    /// </summary>
    public class ToolMenuGroup : ToolMenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuGroup"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="titel">titel van een element.</param>
        public ToolMenuGroup(int id, string titel)
            : base(id, titel, ToolType.Group)
        {
        }
    }
}
