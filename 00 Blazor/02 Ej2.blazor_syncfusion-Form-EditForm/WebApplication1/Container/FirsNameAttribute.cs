// <copyright file="WeatherForecast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Application.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Controleert of de first naam van een pe4rsoon geldig is of niet.
    /// </summary>
    public class FirsNameAttribute : ValidationAttribute
    {
        /// <summary>
        /// Gets or sets De eerste naam van een persoon.
        /// </summary>
        public StringLength EerstNaam { get; set; }

        /// <summary>
        /// Controleert of de value geldig is of niet.
        /// </summary>
        /// <param name="value">De value die vanuit de client komt.</param>
        /// <returns>Is de value geldig is of niet.</returns>
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            string valueToString = value.ToString();
            switch (this.EerstNaam)
            {
                case StringLength.Een:
                    if (valueToString.Length >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        this.ErrorMessage = "De eerst naam moet minimaal een letters.";
                        return false;
                    }

                default:
                    return false;
            }
        }
    }

    /// <summary>
    /// A enumeration of a string.
    /// </summary>
    public enum StringLength
    {
        /// <summary>
        /// Een
        /// </summary>
        Een,

        /// <summary>
        /// twee
        /// </summary>
        Twee,

        /// <summary>
        /// Drie
        /// </summary>
        Drie,
    }
}