// <copyright file="NavigatieItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Navigatie.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// item voor het menu van de linker kant.
    /// </summary>
    public abstract class NavigatieItemModel
    {
        private readonly int id;
        private readonly NavigatietemType navigatieType;

        /// <summary>
        /// List of navigatieItems.
        /// </summary>
        private List<NavigatieItemModel> subItems = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigatieItemModel"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="titel">Title van een item.</param>
        /// <param name="navigatieType">De type van een item.</param>
        /// <param name="isFavoriet">Is de item favoriet of niet.</param>
        public NavigatieItemModel(int id, string titel, NavigatietemType navigatieType, bool isFavoriet = false)
        {
            this.id = id;
            this.Titel = titel;
            this.navigatieType = navigatieType;
            this.IsFavoriet = isFavoriet;
        }

        /// <summary>
        /// Gets de title van een item.
        /// </summary>
        public string Titel { get; private set; } = string.Empty;

        /// <summary>
        /// Gets a value indicating whether gets or sets favorite of niet.
        /// </summary>
        public bool IsFavoriet { get; private set; } = false;

        /// <summary>
        /// Gets a value indicating whether gets or sets  subitem of niet.
        /// </summary>
        public IReadOnlyList<NavigatieItemModel> SubItems => this.subItems as IReadOnlyList<NavigatieItemModel>;

        /// <summary>
        /// Gets put de type van een item.
        /// </summary>
        public NavigatietemType NavigatieType => this.navigatieType;

        /// <summary>
        /// Gets put de id van een item.
        /// </summary>
        public int Id => this.id;

        /// <summary>
        /// Voeg een sub item bij lijst in.
        /// </summary>
        /// <param name="subItem">De subitem die wordt ingevoegd.<param>
        public void AddSubItem(NavigatieItemModel subItem)
        {
            if (this.subItems == null)
            {
                this.subItems = new List<NavigatieItemModel>();
            }

            this.subItems.Add(subItem);
        }

        /// <summary>
        /// Geeft de item eigenschap. Als de item valt in de favorieten map of niet.
        /// </summary>
        /// <param name="isFavoriet">Is deze item valt in de favorietenmap of niet.</param>
        public void FavorietInstellen(bool isFavoriet = true)
        {
            this.IsFavoriet = isFavoriet;
        }

        /// <summary>
        /// functie om de titel te veranderen, controle op dat de titel niet leeg is.
        /// </summary>
        /// <param name="titel">de nieuwe titel.</param>
        public void SetTitel(string titel)
        {
            if (string.IsNullOrWhiteSpace(titel))
            {
                throw new ArgumentException("Titel mag niet leeg zijn.");
            }

            if (this.Titel != titel)
            {
                this.Titel = titel;

                // todo de api aanroepen om de titel te veranderen op de server
            }
        }
    }
}
