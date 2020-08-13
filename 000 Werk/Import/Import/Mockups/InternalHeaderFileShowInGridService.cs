// <copyright file="InternalHeaderFileShowInGridService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Import.Mockups
{
    using HenE.Aeolus.Blazor.Common.Header.Interface;
    using HenE.Aeolus.Blazor.Common.Header.Models;

    /// <summary>
    /// Klas om de items van de header te creëren.
    /// </summary>
    public class InternalHeaderFileShowInGridService : IHeader
    {
        /// <summary>
        /// Geeft de items van het project terug.
        /// </summary>
        /// <returns>Een nieuwe header met de items erin staat.</returns>
        public HeaderItemModel GetHeaderItems()
        {
            return this.GetItems();
        }

        /// <summary>
        /// Geeft een nieuwe header terug.
        /// </summary>
        /// <returns>Een nieuwe header.</returns>
        private HeaderItemModel GetItems()
        {
            return new HeaderItemModel("Import");
        }
    }
}