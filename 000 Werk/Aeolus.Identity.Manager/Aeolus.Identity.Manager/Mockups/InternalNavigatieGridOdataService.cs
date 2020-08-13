// <copyright file="InternalNavigatieGridOdataService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using System.Collections.Generic;
    using HenE.Aeolus.Shared.Ui.Blazor.Navigatie.Interfaces;
    using HenE.Aeolus.Shared.Ui.Blazor.Navigatie.Models;

    /// <summary>
    /// Service om de items voor de navigatie te bouwen.
    /// </summary>
    public class InternalNavigatieGridOdataService : INavigatieService
    {
        private List<NavigatieItemModel> items = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalNavigatieGridOdataService"/> class.
        /// </summary>
        public InternalNavigatieGridOdataService()
        {
            this.Seed();
        }

        /// <inheritdoc/>
        List<NavigatieItemModel> INavigatieService.GetItems()
        {
            return this.items;
        }

        /// <summary>
        /// Add de data van de grid navigatie.
        /// </summary>
        private void Seed()
        {
            this.items = this.AddNavigatieGridOdataItems();
        }

        /// <summary>
        /// Add de items van de navigatie Odata gird.
        /// </summary>
        /// <returns>Een nieuwe navigatie item.</returns>
        private List<NavigatieItemModel> AddNavigatieGridOdataItems()
        {
            return new List<NavigatieItemModel>()
            {
                new PageNavigatieItemModel(1, "APi", "api", true),
                new PageNavigatieItemModel(1, "Vwaangepastewoningen", "vwaangepastewoningen"),
                new PageNavigatieItemModel(1, "WellKnownEntity", "wellKnownEntity"),
            };
        }
    }
}
