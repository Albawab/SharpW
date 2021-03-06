﻿// <copyright file="ExternLinkNavigatieItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace HenE.Aeolus.Blazor.Common.Navigatie.Models
{
    /// <summary>
    /// item voor het menu van de linker kant.
    /// </summary>
    public class ExternLinkNavigatieItemModel : NavigatieItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternLinkNavigatieItemModel"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="titel">Title van een item.</param>
        /// <param name="externeLink">ExterneLink van een item.</param>
        /// <param name="isFavoriet">Is de item favoriet of niet.</param>
        public ExternLinkNavigatieItemModel(int id, string titel, string externeLink, bool isFavoriet = false)
            : base(id, titel, NavigatietemTypeModel.Link, isFavoriet)
        {
            if (string.IsNullOrWhiteSpace(externeLink))
            {
                throw new ArgumentNullException("externe link mag niet leeg of null zijn.");
            }

            // todo nog meer controles dat de link wel correct is
            this.ExterneLink = externeLink;
        }

        /// <summary>
        /// Gets de link waarna verwezen wordt, bijv. https://www.google.nl.
        /// </summary>
        public string ExterneLink { get; private set; }
    }
}
