// <copyright file="IAppService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

    /// <summary>
    /// Interface waar de functies staat in.
    /// </summary>
    public interface IAppService
    {
        /// <summary>
        /// Get de summaries van de data om in de lijst te zetten.
        /// </summary>
        /// <returns>Een summaries van de applicatie.</returns>
        LijstItemsModel GetAppSummaries();

        /// <summary>
        /// Haalt een item van de data en geeft hem terug.
        /// </summary>
        /// <param name="id">De id van een item. De item wordt door deze id gehaalt.</param>
        /// <returns>Een juiste item.</returns>
        BodyModel GetItemAppModel(int id);
    }
}
