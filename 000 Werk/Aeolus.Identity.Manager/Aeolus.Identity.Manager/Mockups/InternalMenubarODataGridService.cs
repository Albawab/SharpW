// <copyright file="InternalMenubarODataGridService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Models;
    using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Interfaces;
    using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Models;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Service om een data van een menubar terug geven.
    /// </summary>
    public class InternalMenubarODataGridService : IMenubarSevice
    {
        private static readonly List<MenubarItemModel> Lists = new List<MenubarItemModel>();
        private readonly List<MenubarItemModel> updateToolmenuItem = Lists;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMenubarODataGridService"/> class.
        /// </summary>
        public InternalMenubarODataGridService()
        {
            this.ToolMenuItem.AddRange(this.GetItems());
        }

        /// <summary>
        /// Gets or sets de element van de tool bar.
        /// </summary>
        public List<MenubarItemModel> ToolMenuItem { get; set; } = new List<MenubarItemModel>();

        /// <summary>
        /// Krijgt de tools bar.
        /// </summary>
        /// <returns>De tools bar.</returns>
        public List<MenubarItemModel> GetMenubarItems()
        {
            return this.ToolMenuItem;
        }

        /// <inheritdoc/>
        public void Update(BodyModel item)
        {
            throw new NotImplementedException();
        }

        private List<MenubarItemModel> GetItems()
        {
            List<MenubarItemModel> result = new List<MenubarItemModel>();
            result.Add(new MenubarLinkModel(1, "Excel Exporteren"));
            result.Add(new MenubarLinkModel(3, "Pdf Exporteren"));
            return result;
        }
    }
}
