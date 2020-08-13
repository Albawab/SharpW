// <copyright file="Order.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Overzichten.Blazor.Data
{
    using System.ComponentModel;

    /// <summary>
    /// Een klas van de order waarin de properties staan.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets de id van de order.
        /// </summary>
        [Description("ID")]
        public int OrderID { get; set; }
    }
}
