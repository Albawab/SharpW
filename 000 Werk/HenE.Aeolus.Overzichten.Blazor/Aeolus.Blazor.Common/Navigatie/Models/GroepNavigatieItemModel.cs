// <copyright file="GroepNavigatieItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Navigatie.Models
{
    /// <summary>
    /// item voor het menu van de linker kant.
    /// </summary>
    public class GroepNavigatieItemModel : NavigatieItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroepNavigatieItemModel"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="titel">De titel van een item.</param>
        /// <param name="isFavoriet">Valt deze item in de favoriten map of niet.</param>
        public GroepNavigatieItemModel(int id, string titel, bool isFavoriet = false)
            : base(id, titel, NavigatietemTypeModel.Groep, isFavoriet)
        {
        }
    }
}
