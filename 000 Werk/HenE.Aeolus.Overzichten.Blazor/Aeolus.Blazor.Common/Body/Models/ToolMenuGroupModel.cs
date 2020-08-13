// <copyright file="ToolMenuGroup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Blazor.Common.Body.Models
{

    /// <summary>
    /// Klas waar de properties van een item groep staat in.
    /// </summary>
    public class ToolMenuGroupModel : ToolMenuItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuGroupModel"/> class.
        /// </summary>
        /// <param name="id">Id van een element.</param>
        /// <param name="titel">titel van een element.</param>
        public ToolMenuGroupModel(int id, string titel)
            : base(id, titel, ToolType.Group)
        {
        }
    }
}
