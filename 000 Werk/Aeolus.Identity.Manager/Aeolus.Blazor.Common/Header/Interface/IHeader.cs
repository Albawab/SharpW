// <copyright file="IHeader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Header.Interface
{
    using HenE.Aeolus.Blazor.Common.Header.Models;

    /// <summary>
    /// Interface van de header.
    /// </summary>
    public interface IHeader
    {
        /// <summary>
        /// Geeft de items van de header terug.
        /// </summary>
        /// <returns>Een nieuwe header met de items.</returns>
        HeaderItemModel GetHeaderItems();
    }
}
