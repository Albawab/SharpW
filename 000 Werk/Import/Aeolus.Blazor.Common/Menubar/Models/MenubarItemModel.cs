// <copyright file="MenubarItemModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Klas waar de properties van een item staat in.
    /// </summary>
    public class MenubarItemModel
    {
        /// <summary>
        /// Een lijst met inhouden van tools bar.
        /// </summary>
        private List<MenubarItemModel> toolMenuItems = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MenubarItemModel"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="title">Titel van een tool.</param>
        /// <param name="type">Type van een tool.</param>
        public MenubarItemModel(int id, string title, MenubarType type)
        {
            this.Id = id;
            this.Titel = title;
            this.Type = type;
        }

        /// <summary>
        /// Gets de items van de toolbar.
        /// </summary>
        public IReadOnlyList<MenubarItemModel> ToolMenuItems => this.toolMenuItems as IReadOnlyList<MenubarItemModel>;

        /// <summary>
        /// Gets or sets de id van een item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// gets or sets de titel van een item.
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Gets or sets de type van een element.
        /// </summary>
        public MenubarType Type { get; set; }

        /// <summary>
        /// Add een nieuwe sub item aan de lijst.
        /// </summary>
        /// <param name="subitem">De nieuwe item die wordt ingevoegd.</param>
        public void AddSubItembar(MenubarItemModel subitem)
        {
            if (this.toolMenuItems == null)
            {
                this.toolMenuItems = new List<MenubarItemModel>();
            }

            this.toolMenuItems.Add(subitem);
        }
    }
}
