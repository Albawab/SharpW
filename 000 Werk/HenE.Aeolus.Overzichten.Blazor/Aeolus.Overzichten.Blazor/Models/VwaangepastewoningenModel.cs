// <copyright file="VwaangepastewoningenModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Overzichten.Blazor.Data
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Vw aangepastewoningen waarin de properties van de woningen staatn.
    /// </summary>
    public class VwaangepastewoningenModel
    {
        /// <summary>
        /// Gets or sets de id van een woning.
        /// </summary>
        [Description("ID")]
        public int Vwaangepastewoningenid { get; set; }

        /// <summary>
        /// Gets or sets de nummer van de aanvraag.
        /// </summary>
        public string Aanvraagnummer { get; set; }

        /// <summary>
        /// Gets or sets de datum van de aanvraag.
        /// </summary>
        public DateTime? Aanvraagdatum { get; set; }

        /// <summary>
        /// Gets or sets de type van het adres.
        /// </summary>
        [Description("Type adres")]
        public string Typeadres { get; set; }

        /// <summary>
        /// Gets or sets de straat van de woning.
        /// </summary>
        public string Straat { get; set; }

        /// <summary>
        /// Gets or sets het postcode van de woning.
        /// </summary>
        [Description("Postcode")]
        public string Postcode1 { get; set; }

        /// <summary>
        /// Gets or sets de plaats van de woning.
        /// </summary>
        public string Plaats { get; set; }

        /// <summary>
        /// Gets or sets de aanpassingen van de woning.
        /// </summary>
        public string Geraanpassingen { get; set; }

        /// <summary>
        /// Gets or sets de product.
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets de psn nummer.
        /// </summary>
        public string Bsn { get; set; }

        /// <summary>
        /// Gets or sets de cliënt van de woning.
        /// </summary>
        public string Client { get; set; }
    }
}
