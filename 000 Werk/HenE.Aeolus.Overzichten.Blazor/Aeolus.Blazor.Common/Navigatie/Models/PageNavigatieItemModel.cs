// <copyright file="PageNavigatieItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Navigatie.Models
{
    using System;

    /// <summary>
    /// item voor het menu van de linker kant.
    /// </summary>
    public class PageNavigatieItemModel : NavigatieItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageNavigatieItemModel"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="titel">Title van een item.</param>
        /// <param name="page">Naam van een page.</param>
        /// <param name="isFavoriet">Is de item favoriet of niet.</param>
        public PageNavigatieItemModel(int id, string titel, string page, bool isFavoriet = false)
            : base(id, titel, NavigatietemTypeModel.Page, isFavoriet)
        {
            if (string.IsNullOrWhiteSpace(page))
            {
                throw new ArgumentNullException("page mag niet leeg of null zijn.");
            }

            // todo nog meer controles dat de link wel correct is
            this.Page = page;
        }

        /// <summary>
        /// Gets als het item een page is dan staat hier de page link in.
        /// </summary>
        public string Page { get; private set; }

        // moet dit een string zijn of een enum of een typeof van het model?
    }
}
