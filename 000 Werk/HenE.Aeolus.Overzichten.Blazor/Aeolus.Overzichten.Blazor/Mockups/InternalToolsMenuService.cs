// <copyright file="InternalToolsMenuService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Overzichten.Blazor.Mockups
{    
    using System.Collections.Generic;
    using Aeolus.Blazor.Common.Body.Interfaces;
    using Aeolus.Blazor.Common.Body.Models;

    /// <summary>
    /// Klas om de tools bar uit de server te halen.
    /// </summary>
    public class InternalToolsMenuService : IBodyService
    {
        private List<ToolMenuItemModel> toolmenuItem = new List<ToolMenuItemModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalToolsMenuService"/> class.
        /// </summary>
        public InternalToolsMenuService()
        {
            this.ToolMenuItem.AddRange(this.GetItems());
        }

        /// <summary>
        /// Gets or sets de element van de tool bar.
        /// </summary>
        public List<ToolMenuItemModel> ToolMenuItem { get => this.toolmenuItem; set => this.toolmenuItem = value; }

        /// <summary>
        /// Krijgt de tools bar.
        /// </summary>
        /// <returns>De tools bar.</returns>
        public List<ToolMenuItemModel> GetToolItems()
        {
            return this.ToolMenuItem;
        }

        /// <summary>
        /// Geeft een lijst van toolsbar terug.
        /// </summary>
        /// <returns>Een lijst van een tool bar.</returns>
        private List<ToolMenuItemModel> GetItems()
        {
            List<ToolMenuItemModel> result = new List<ToolMenuItemModel>();
            result.Add(new ToolMenuLinkModel(1, "Excel Exporteren"));
            result.Add(new ToolMenuLinkModel(2, "Pdf Exporteren"));
            return result;
        }
    }
}
