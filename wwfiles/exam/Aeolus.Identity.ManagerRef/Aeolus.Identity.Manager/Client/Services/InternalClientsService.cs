// <copyright file="InternalClientsService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Client.Services
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
    using HenE.Aeolus.Identity.Manager.Client.Models;

    /// <summary>
    /// Klas om data vanuit de api te halen.
    /// </summary>
    public class InternalClientsService : IAppService, ILijstItemsService
    {
        private List<ClientModel> bodyModels = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalClientsService"/> class.
        /// </summary>
        public InternalClientsService()
        {
            this.Seeds();
        }

        /// <inheritdoc/>
        public BodyModel GetItemAppModel(int id)
        {
            ClientModel huidigeItem = null;
            foreach (ClientModel item in this.bodyModels)
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
            LijstItemsModel lijstItemsModel = new LijstItemsModel("Test 2")
            {
                Kinderen = new List<LijstItemsModel>(),
            };

            foreach (var item in this.bodyModels)
            {
                lijstItemsModel.Kinderen.Add(new LijstItemModel(item.Id, item.Name, item.IP));
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
            this.bodyModels = new List<ClientModel>()
            {
             new ClientModel() { Id = 0, Name = "Client 0", IP = "This is Client 0" },
             new ClientModel() { Id = 1, Name = "Client 1", IP = "This is Client 1" },
             new ClientModel() { Id = 2, Name = "Client 2", IP = "This is Client 2" },
             new ClientModel() { Id = 3, Name = "Client 3", IP = "This is Client 3" },
             new ClientModel() { Id = 4, Name = "Client 4", IP = "This is Client 4" },
             new ClientModel() { Id = 5, Name = "Client 5", IP = "This is Client 5" },
             new ClientModel() { Id = 6, Name = "Client 6", IP = "This is Client 6" },
             new ClientModel() { Id = 7, Name = "Client 7", IP = "This is Client 7" },
             new ClientModel() { Id = 8, Name = "Client 8", IP = "This is Client 8" },
             new ClientModel() { Id = 9, Name = "Client 9", IP = "This is Client 9" },
             new ClientModel() { Id = 10, Name = "Client 10", IP = "This is Client 10" },
             new ClientModel() { Id = 11, Name = "Client 11", IP = "This is Client 11" },
            };
        }
    }
}
