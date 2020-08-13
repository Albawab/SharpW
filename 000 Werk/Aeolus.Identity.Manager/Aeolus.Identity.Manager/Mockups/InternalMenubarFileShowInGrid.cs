// <copyright file="InternalMenubarFileShowInGrid.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using System;
    using System.Collections.Generic;
    using HenE.Aeolus.Shared.Ui.Blazor.ListAndItemsBody.Models;
    using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Interfaces;
    using HenE.Aeolus.Shared.Ui.Blazor.Menubar.Models;

    /// <summary>
    /// Klas om de items van de menubar maken.
    /// </summary>
    public class InternalMenubarFileShowInGrid : IMenubarSevice
    {
        private readonly List<MenubarItemModel> menuItems = new List<MenubarItemModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMenubarFileShowInGrid"/> class.
        /// </summary>
        public InternalMenubarFileShowInGrid()
        {
            this.menuItems.AddRange(this.GetItems());
        }

        /// <summary>
        /// Gets de menubar items.
        /// </summary>
        public List<MenubarItemModel> MenubarItems { get => this.menuItems; }

        /// <summary>
        /// Gaat de menubar updaten.
        /// </summary>
        /// <param name="item">De item die wordt upgedaten.</param>
        public void Update(BodyModel item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Geeft de items van het menubar terug.
        /// </summary>
        /// <returns>Een lijst van het menubar.</returns>
        public List<MenubarItemModel> GetMenubarItems()
        {
            return this.menuItems;
        }

        private List<MenubarItemModel> GetItems()
        {
            return new List<MenubarItemModel>()
            {
                new MenubarDialogModel(0, "Inlezen") { Kinderen = new List<MenubarItemModel>() { new MenubarUploadFileModel(0, "Upload file"), new MenubarButtonModel(1, "OK") } },
                new MenubarLinkModel(1, "Verwerken"),
            };
        }
    }
}
