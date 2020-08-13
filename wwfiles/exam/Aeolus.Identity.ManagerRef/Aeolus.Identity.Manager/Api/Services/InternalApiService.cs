// <copyright file="InternalApiService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Api.Services
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
    using HenE.Aeolus.Identity.Manager.Api.Models;

    /// <summary>
    /// Klas om data vanuit de api te halen.
    /// </summary>
    public class InternalApiService : IAppService, ILijstItemsService
    {
        private List<ApiModel> bodyModels = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalApiService"/> class.
        /// </summary>
        public InternalApiService()
        {
            this.Seeds();
        }

        /// <inheritdoc/>
        public BodyModel GetItemAppModel(int id)
        {
            ApiModel huidigeItem = null;
            foreach (ApiModel item in this.bodyModels)
            {
                if (id == item.Id)
                {
                    huidigeItem = item;
                }
            }

            return huidigeItem;
        }

        /// <inheritdoc/>
        public LijstItemsModel GetAppSummaries()
        {
            LijstItemsModel lijstItemsModel = new LijstItemsModel("Test 1")
            {
                Kinderen = new List<LijstItemsModel>(),
            };

            foreach (var item in this.bodyModels)
            {
                lijstItemsModel.Kinderen.Add(new LijstItemModel(item.Id, item.Titel, item.Omschrijving));
            }

            return lijstItemsModel;
        }

        /// <inheritdoc/>
        public LijstItemsModel GetListItems()
        {
            return this.GetAppSummaries();
        }

        private void Seeds()
        {
            this.bodyModels = new List<ApiModel>()
            {
             new ApiModel() { Id = 0, Titel = "Api 0", Omschrijving = "This is Api 0" },
             new ApiModel() { Id = 1, Titel = "Api 1", Omschrijving = "This is Api 1, This is Api 1, This is Api 1, This is Api 1, " },
             new ApiModel() { Id = 2, Titel = "Api 2", Omschrijving = "This is Api 2" },
             new ApiModel() { Id = 3, Titel = "Api 3", Omschrijving = "This is Api 3" },
             new ApiModel() { Id = 4, Titel = "Api 4", Omschrijving = "This is Api 4" },
             new ApiModel() { Id = 5, Titel = "Api 5", Omschrijving = "This is Api 5" },
             new ApiModel() { Id = 6, Titel = "Api 6", Omschrijving = "This is Api 6" },
            };
        }
    }
}
