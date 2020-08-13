// <copyright file="IShowFileInGrid.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ShowFileInGrid.Interfaces
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.ShowFileInGrid.Model;

    /// <summary>
    /// Interface om de items van een de excel ophalen.
    /// </summary>
    public interface IShowFileInGrid
    {
        /// <summary>
        /// Gets de data van een Excel bestand.
        /// </summary>
        /// <param name="fileName">De naam van het bestand.</param>
        /// <returns>Een lijst met data die wordt van een Excel bestand opgehaald.</returns>
        List<ExcelCelModel> GetExcelItems(string fileName);
    }
}
