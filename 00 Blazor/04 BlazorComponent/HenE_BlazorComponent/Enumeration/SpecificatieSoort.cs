// <copyright file="SpecificatieSoort.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Enumeration
{
    /// <summary>
    /// De sert van de grid.
    /// </summary>
    public enum SpecificatieSoort
    {
        /// <summary>
        /// Kan inline een element veranderen.
        /// </summary>
        InlineEditing,

        /// <summary>
        /// Kan Dialog een element veranderen.
        /// </summary>
        DialogEditing,

        /// <summary>
        /// Kan Batch een element veranderen.
        /// </summary>
        BatchEditing,

        /// <summary>
        /// Geen Grid.
        /// </summary>
        Normaal,
    }
}
