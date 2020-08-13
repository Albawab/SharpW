// <copyright file="InternalNavigatieFileShowInGrid.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Import.Mockups
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.Navigatie.Interfaces;
    using HenE.Aeolus.Blazor.Common.Navigatie.Models;

    /// <summary>
    /// Klas om de items van navigatie te creëren.
    /// </summary>
    public class InternalNavigatieFileShowInGrid : INavigatieService
    {
        private List<NavigatieItemModel> navigatieItems = new List<NavigatieItemModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalNavigatieFileShowInGrid"/> class.
        /// </summary>
        public InternalNavigatieFileShowInGrid()
        {
            this.navigatieItems.AddRange(this.GetNavigatieItems());
        }

        /// <summary>
        /// Gets or sets de element van de tool bar.
        /// </summary>
        public List<NavigatieItemModel> NavigatieItems { get => this.navigatieItems; set => this.navigatieItems = value; }

        /// <inheritdoc/>
        public List<NavigatieItemModel> GetItems()
        {
            return this.NavigatieItems;
        }

        private List<NavigatieItemModel> GetNavigatieItems()
        {
            return new List<NavigatieItemModel>()
            {
                new PageNavigatieItemModel(0, "Formulier", "formulier", true),
                new PageNavigatieItemModel(1, "Profiel", "profiel", false),
            };
        }
    }
}
