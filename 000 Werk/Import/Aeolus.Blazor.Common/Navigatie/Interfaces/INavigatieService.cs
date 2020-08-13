// <copyright file="INavigatieService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Navigatie.Interfaces
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.Navigatie.Models;

    /// <summary>
    /// Interface van de navigator.
    /// </summary>
    public interface INavigatieService
    {
        /// <summary>
        /// Gets de items van de navigator.
        /// </summary>
        /// <returns>Een lijst met de navigatior items.</returns>
        List<NavigatieItemModel> GetItems();
    }
}
