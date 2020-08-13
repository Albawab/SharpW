// <copyright file="IHandleMenubar.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.Menubar.Models;

    /// <summary>
    /// Interface van de handelaar van een menu bar.
    /// </summary>
    public interface IHandleMenubar
    {
        /// <summary>
        /// Gets de items van het menu bar.
        /// </summary>
        /// <returns>Een lijst met de items van de menu bar.</returns>
        List<MenubarItemModel> GetMenubarItems();
    }
}
