// <copyright file="Formulier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// De basis formulier.
    /// </summary>
    public class Formulier
    {
        public Formulier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Formulier"/> class.
        /// </summary>
        /// <param name="titel">Titel.</param>
        public Formulier(string titel)
        {
            this.Titel = titel;
        }

        /// <summary>
        /// gets or sets id van een formulier.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets de title van het formulier.
        /// </summary>
        public string Titel { get; }

        /// <summary>
        /// Gets or sets de sections van een formulier.
        /// </summary>
        public List<FormulierElement> Kinderen { get; set; }
    }
}
