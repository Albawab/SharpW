// <copyright file="InPlaceEditor.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Application.Container
{
    /// <summary>
    /// Hier staat de data van de appication.
    /// </summary>
    public class InPlaceEditor
    {
        /// <summary>
        /// Gets or sets de Name.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets de comments.
        /// </summary>
        public string Comments { get; set; }
        public int PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets de tags.
        /// </summary>
        public string[] Tags { get; set; }
    }
}
