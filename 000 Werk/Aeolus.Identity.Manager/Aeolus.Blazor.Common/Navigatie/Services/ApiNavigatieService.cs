// <copyright file="ApiNavigatieService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Blazor.Common.Navigatie.Services
{
    using System;
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
    using HenE.Aeolus.Blazor.Common.Menubar.Interfaces;
    using HenE.Aeolus.Blazor.Common.Menubar.Models;

    /// <summary>
    /// Service om de navigatie te geven.
    /// </summary>
    public class ApiNavigatieService : IMenubarSevice
    {
        /// <inheritdoc/>
        public List<MenubarItemModel> GetMenubarItems()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Update(BodyModel item)
        {
            throw new NotImplementedException();
        }
    }
}
