// <copyright file="JsonNavigationServer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Blazor.Common.Navigatie.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Aeolus.Blazor.Common.Navigatie.Interfaces;
    using HenE.Aeolus.Blazor.Common.Navigatie.Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Klas om de json file te lezen.
    /// </summary>
    public class JsonNavigationServer : INavigatieService
    {
        public NavigatieItemModel[] NavigatieItems;
        public NavigatieItemModel[] navigatieItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonNavigationServer"/> class.
        /// </summary>
        public JsonNavigationServer()
        {
            StreamReader streamReader = new StreamReader(@"Mockups\JsonNavigatieMenuServer.json");
            StreamReader reader = streamReader;
            string json = reader.ReadToEnd();
            //this.NavigatieItems = JsonConvert.DeserializeObject<NavigatieItemModel[]>(json);
           // navigatieItems = JsonConvert.DeserializeObject<NavigatieItemModel[]>(json);
        }

        /// <summary>
        /// Geeft de items van navigatie terug.
        /// </summary>
        /// <returns>Een list van items.</returns>
        public List<NavigatieItemModel> GetItems()
        {
            return this.NavigatieItems.ToList();
            return navigatieItems.ToList();
        }
    }
}
