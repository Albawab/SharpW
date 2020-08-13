// <copyright file="InternalUsersService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.User.Services
{
    using System.Collections.Generic;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces;
    using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;
    using HenE.Aeolus.Identity.Manager.User.Models;

    /// <summary>
    /// Klas om data vanuit de api te halen.
    /// </summary>
    public class InternalUsersService : IAppService, ILijstItemsService
    {
        private List<UserModel> bodyModels = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalUsersService"/> class.
        /// </summary>
        public InternalUsersService()
        {
            this.Seeds();
        }

        /// <inheritdoc/>
        public BodyModel GetItemAppModel(int id)
        {
            UserModel huidigeItem = null;
            foreach (UserModel item in this.bodyModels)
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
                lijstItemsModel.Kinderen.Add(new LijstItemModel(item.Id, item.Name, item.Address));
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
            this.bodyModels = new List<UserModel>()
            {
             new UserModel() { Id = 0, Name = "User 0", Address = "This is User 0" },
             new UserModel() { Id = 1, Name = "User 1", Address = "This is User 1" },
             new UserModel() { Id = 2, Name = "User 2", Address = "This is User 2" },
             new UserModel() { Id = 3, Name = "User 3", Address = "This is User 3" },
             new UserModel() { Id = 4, Name = "User 4", Address = "This is User 4" },
             new UserModel() { Id = 5, Name = "User 5", Address = "This is User 5" },
             new UserModel() { Id = 6, Name = "User 6", Address = "This is User 6" },
            };
        }
    }
}
