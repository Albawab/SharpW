// <copyright file="ExcelCelModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Data;

namespace HenE.Aeolus.Blazor.Common.ShowFileInGrid.Model
{
    /// <summary>
    /// Een klas waar de properties van een element zetten.
    /// </summary>
    public class ExcelCelModel
    {
        /// <summary>
        /// Gets or sets gers or sets de id van een element.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets de naam van een cel.
        /// </summary>
        public string Value { get; set; }

    }
}
