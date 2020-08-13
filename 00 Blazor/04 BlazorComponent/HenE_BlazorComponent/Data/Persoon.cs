// <copyright file="Persoon.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// De klas waar de gegevens van een persoon staat.
    /// </summary>
    public class Persoon
    {
        /// <summary>
        /// Gets or sets de id van een persoon.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets de naam van een persoon.
        /// </summary>
        [Required]
        public string Naam { get; set; }

        /// <summary>
        /// Gets or sets de achter naam van een persoon.
        /// </summary>
        public string Achternaam { get; set; }

        /// <summary>
        /// Gets or sets de email van een persoon.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets de telefoon nummer van een persoon.
        /// </summary>
        public string Wachtwoord { get; set; }
    }
}
