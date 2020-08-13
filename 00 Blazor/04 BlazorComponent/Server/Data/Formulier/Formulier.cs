// <copyright file="Formulier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// De basis formulier.
    /// </summary>
    public class Formulier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Formulier"/> class.
        /// </summary>
        /// <param name="titel">Titel.</param>
        public Formulier(string titel)
        {
            this.Titel = titel;
        }

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
