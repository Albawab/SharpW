// <copyright file="ToolMenuItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Overzichten.Blazor.Models.Body
{
    using System.Collections.Generic;
    using HenE.Aeolus.Overzichten.Blazor.Enumeration;

    /// <summary>
    /// Klas waar de properties van een item staat in.
    /// </summary>
    public class ToolMenuItem
    {
        /// <summary>
        /// Een lijst met inhouden van tools bar.
        /// </summary>
        private List<ToolMenuItem> toolMenuItems = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMenuItem"/> class.
        /// </summary>
        /// <param name="id">Id van een item.</param>
        /// <param name="title">Titel van een tool.</param>
        /// <param name="type">Type van een tool.</param>
        public ToolMenuItem(int id, string title, ToolType type)
        {
            this.Id = id;
            this.Titel = title;
            this.Type = type;
        }

        /// <summary>
        /// Gets de items van de toolbar.
        /// </summary>
        public IReadOnlyList<ToolMenuItem> ToolMenuItems => this.toolMenuItems as IReadOnlyList<ToolMenuItem>;

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
        public ToolType Type { get; set; }

        /// <summary>
        /// Add een nieuwe sub item aan de lijst.
        /// </summary>
        /// <param name="subitem">De nieuwe item die wordt ingevoegd.</param>
        public void AddSubItembar(ToolMenuItem subitem)
        {
            if (this.toolMenuItems == null)
            {
                this.toolMenuItems = new List<ToolMenuItem>();
            }

            this.toolMenuItems.Add(subitem);
        }
    }
}
