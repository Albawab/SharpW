// <copyright file="IUpdateComponent.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using HenE.Aeolus.Blazor.Common.ListAndItemsBody.Models;

namespace HenE.Aeolus.Blazor.Common.ListAndItemsBody.Interfaces
{ 
    /// <summary>
    /// Interface waar de functies staat in.
    /// </summary>
    public interface IUpdateComponent
    {
        /// <summary>
        /// Vernieuwt de item van de component..
        /// </summary>
        /// <param name="key">De key van de item die wordt upgedate.</param>
        /// <returns>Een item.</returns>
        BodyModel UpdateComponent(int key);
    }
}
