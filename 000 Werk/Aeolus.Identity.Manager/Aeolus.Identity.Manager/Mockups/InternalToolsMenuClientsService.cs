﻿// <copyright file="InternalToolsMenuClientsService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Models;
    using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Interfaces;
    using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Klas om de tools bar uit de server te halen.
    /// </summary>
    public class InternalToolsMenuClientsService : IMenubarSevice
    {
        private readonly List<MenubarItemModel> updateToolmenuItem = new List<MenubarItemModel>();
        private List<MenubarItemModel> toolmenuItem = new List<MenubarItemModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalToolsMenuClientsService"/> class.
        /// </summary>
        public InternalToolsMenuClientsService()
        {
            this.ToolMenuItem.AddRange(this.GetItems());
        }

        /// <summary>
        /// Gets or sets de element van de tool bar.
        /// </summary>
        public List<MenubarItemModel> ToolMenuItem { get => this.toolmenuItem; set => this.toolmenuItem = value; }

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
            if (item.Id == 1)
            {
                this.updateToolmenuItem.Add(new MenubarItemModel(0, "item 1", MenubarType.Link) { });
            }
            else
            {
                this.updateToolmenuItem.Add(new MenubarItemModel(0, "item 2", MenubarType.Link) { });
            }
        }

        /// <summary>
        /// Geeft een lijst van toolsbar terug.
        /// </summary>
        /// <returns>Een lijst van een tool bar.</returns>
        private List<MenubarItemModel> GetItems()
        {
            List<MenubarItemModel> result = new List<MenubarItemModel>();
            result.Add(new MenubarButtonModel(1, "Excel Exporteren"));
            result.Add(new MenubarButtonModel(3, "Pdf Exporteren"));
            return result;
        }
    }
}
