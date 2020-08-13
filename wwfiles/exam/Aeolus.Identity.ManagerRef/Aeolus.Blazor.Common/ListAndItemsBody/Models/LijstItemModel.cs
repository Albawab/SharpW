// <copyright file="PageNavigatieItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models
{
    public class LijstItemModel : LijstItemsModel
    {
        public LijstItemModel(int id, string title, string omschrijving) : base(title)
        {
            Omschrijving = omschrijving;
            this.Id = id;
        }

        public string Omschrijving { get; set; }

        public DateTime DateTime { get; set; }

        public string Uri { get; set; }

    }
}