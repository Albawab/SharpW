// <copyright file="InternalNavigatieService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Blazor.Overzichten.Mockups
{
    using System.Collections.Generic;
    using Aeolus.Blazor.Common.Navigatie.Interfaces;
    using global::HenE.Aeolus.Blazor.Common.Navigatie.Models;

    /// <summary>
    /// Klas om de data uit de server te halen.
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
            this.items.Add(this.GetgroepEen());
            this.items.Add(this.GetgroepTwee());
            this.items.Add(this.GetgroepDrie());
            this.items.Add(this.GetgroepVier());
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

        private NavigatieItemModel GetgroepEen()
        {
            GroepNavigatieItemModel groep = new GroepNavigatieItemModel(1, "Woningen 1");
            groep.AddSubItem(new PageNavigatieItemModel(1, "Vwaangepastewoningen", "vwaangepastewoningen"));
            groep.AddSubItem(new PageNavigatieItemModel(2, "Order", "order"));
            groep.AddSubItem(new PageNavigatieItemModel(3, "Items 4", "vw.."));

            return groep;
        }

        private NavigatieItemModel GetgroepTwee()
        {
            GroepNavigatieItemModel groep = new GroepNavigatieItemModel(2, "Woningen 2");
            groep.AddSubItem(new PageNavigatieItemModel(1, "Items 2", "vw.."));
            groep.AddSubItem(new PageNavigatieItemModel(2, "Items 3", "vw..", true));
            var subitem = new PageNavigatieItemModel(3, "Items 4", "vw..");
            subitem.AddSubItem(new PageNavigatieItemModel(4, "Items 5", "vw..", true));
            groep.AddSubItem(subitem);

            return groep;
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
