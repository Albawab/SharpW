// <copyright file="ILijstItemsService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

    /// <summary>
    /// Interface van de lijst.
    /// </summary>
    public interface ILijstItemsService
    {
        /// <summary>
        /// Geeft de items van de lijst terug.
        /// </summary>
        /// <returns>Een list met items van de lijst model.</returns>
        LijstItemsModel GetListItems();
    }
}
