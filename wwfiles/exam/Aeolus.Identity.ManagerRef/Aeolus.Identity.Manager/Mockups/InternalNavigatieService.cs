// <copyright file="InternalNavigatieService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.Navigatie.Interfaces;
    using HenE.Aeolus.Blazor.Common.Navigatie.Models;

    /// <summary>
    /// Deze klas gaat de data ophalen en aan de applicatie het geven.
    /// </summary>
    public class InternalNavigatieService : INavigatieService
    {
        private readonly List<NavigatieItemModel> items = new List<NavigatieItemModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalNavigatieService"/> class.
        /// </summary>
        public InternalNavigatieService()
        {
            this.Seed();
        }

        /// <inheritdoc/>
        List<NavigatieItemModel> INavigatieService.GetItems()
        {
            return this.items;
        }

        /// <summary>
        /// functie om de data op te halen.
        /// </summary>
        public void Seed()
        {
            this.items.Add(this.GetApiPage());
            this.items.Add(this.GetCleintPage());
            this.items.Add(this.GetUsersPage());
            this.items.Add(this.GetgroepVijf());
        }

        /// <summary>
        /// Geeft de navigati Items terug.
        /// </summary>
        /// <returns>Een lijst waar de items van de navigatie staat in.</returns>
        public List<NavigatieItemModel> GetNavigatieItems()
        {
            return this.items;
        }

        /// <summary>
        /// Geeft de favorit elementen terug.
        /// </summary>
        /// <returns>Lijst van elementen.</returns>
        public List<NavigatieItemModel> GetFavorietenNavigatieItems()
        {
            List<NavigatieItemModel> result = new List<NavigatieItemModel>();

            foreach (var item in this.items)
            {
                result.AddRange(this.GetFavorietenNavigatieItems(item));
            }

            return result;
        }

        /// <summary>
        /// Geeft alle mappen elementen terug.
        /// </summary>
        /// <returns>Lijst van elementen.</returns>
        public List<NavigatieItemModel> GetAlleMappenNavigatieItems()
        {
            List<NavigatieItemModel> result = new List<NavigatieItemModel>();

            foreach (var item in this.items)
            {
                result.AddRange(this.GetAlleMappenNavigatieItems(item));
            }

            return result;
        }

        private List<NavigatieItemModel> GetFavorietenNavigatieItems(NavigatieItemModel parentItem)
        {
            List<NavigatieItemModel> result = new List<NavigatieItemModel>();

            if (parentItem.IsFavoriet)
            {
                result.Add(parentItem);
            }

            if (parentItem.SubItems != null)
            {
                foreach (var item in parentItem.SubItems)
                {
                    result.AddRange(this.GetFavorietenNavigatieItems(item));
                }
            }

            return result;
        }

        private List<NavigatieItemModel> GetAlleMappenNavigatieItems(NavigatieItemModel parentItem)
        {
            List<NavigatieItemModel> result = new List<NavigatieItemModel>();

            if (!parentItem.IsFavoriet)
            {
                result.Add(parentItem);
            }

            if (parentItem.SubItems != null)
            {
                foreach (var item in parentItem.SubItems)
                {
                    result.AddRange(this.GetAlleMappenNavigatieItems(item));
                }
            }

            return result;
        }

        private NavigatieItemModel GetApiPage()
        {
            PageNavigatieItemModel apiPage = new PageNavigatieItemModel(1, "Api", "apiPage");

            return apiPage;
        }

        private NavigatieItemModel GetCleintPage()
        {
            PageNavigatieItemModel cleintPage = new PageNavigatieItemModel(2, "Clients", "clientPage");

            return cleintPage;
        }

        private NavigatieItemModel GetUsersPage()
        {
            PageNavigatieItemModel userPage = new PageNavigatieItemModel(3, "Users", "userPage");

            return userPage;
        }

        private NavigatieItemModel GetgroepDrie()
        {
            GroepNavigatieItemModel groep = new GroepNavigatieItemModel(3, "Woningen 3");
            return groep;
        }

        private NavigatieItemModel GetgroepVier()
        {
            GroepNavigatieItemModel groep = new GroepNavigatieItemModel(4, "Woningen 4");
            return groep;
        }

        private NavigatieItemModel GetgroepVijf()
        {
            GroepNavigatieItemModel groep = new GroepNavigatieItemModel(5, "Index", true);
            return groep;
        }
    }
}
