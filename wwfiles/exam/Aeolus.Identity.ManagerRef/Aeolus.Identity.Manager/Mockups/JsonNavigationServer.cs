// <copyright file="JsonNavigationServer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Mockups
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using global::HenE.Aeolus.Blazor.Common.Navigatie.Interfaces;
    using HenE.Aeolus.Blazor.Common.Navigatie.Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Klas om de json file te lezen.
    /// </summary>
    public class JsonNavigationServer : INavigatieService
    {
        /// <summary>
        /// De items van navigatie.
        /// </summary>
        private readonly NavigatieItemModel[] navigatieItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonNavigationServer"/> class.
        /// </summary>
        public JsonNavigationServer()
        {
            StreamReader streamReader = new StreamReader(@"Mockups\JsonNavigatieMenuServer.json");
            StreamReader reader = streamReader;
            string json = reader.ReadToEnd();
            this.navigatieItems = JsonConvert.DeserializeObject<NavigatieItemModel[]>(json);
        }

        /// <summary>
        /// Geeft de items van navigatie terug.
        /// </summary>
        /// <returns>Een list van items.</returns>
        public List<NavigatieItemModel> GetItems()
        {
            return this.navigatieItems.ToList();
        }
    }
}
