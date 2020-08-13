// <copyright file="ICanUpdateView.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{
    /// <summary>
    /// interface om de view te updaten.
    /// </summary>
    public interface ICanUpdateView
    {
        /// <summary>
        /// Update een view.
        /// </summary>
        /// <param name="key">key van item die wordt opgehald door deze key.</param>
        void UpdateView(string key);
    }
}
