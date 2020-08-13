// <copyright file="IMenubarSevice.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Interfaces
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
    using HenE.Aeolus.Blazor.Common.Menubar.Models;

    /// <summary>
    /// Interface van een menubar.
    /// </summary>
    public interface IMenubarSevice
    {
        /// <summary>
        /// Geeft de items van een menu bar terug.
        /// </summary>
        /// <returns>Een lijst van de menu bar.</returns>
        List<MenubarItemModel> GetMenubarItems();

        /// <summary>
        /// Update de menubar.
        /// </summary>
        /// <param name="item">De items die wordt upgedate.</param>
        void Update(BodyModel item);
    }
}
