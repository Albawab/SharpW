// <copyright file="InternalHeaderFileShowInGridService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using HenE.Aeolus.Shared.Ui.Blazor.Header.Interface;
    using HenE.Aeolus.Shared.Ui.Blazor.Header.Models;

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
            return new HeaderItemModel("Import", HeaderItemType.Titel)
            {
                Kinderen = new System.Collections.Generic.List<HeaderItemModel>(){
            new HeaderIconModel("Header","web-api.png"),
            new HeaderTitelModel("Header"),
            },
            };
        }
    }
}
