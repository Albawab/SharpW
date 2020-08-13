// <copyright file="WeatherGermany.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Application.Data
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The weather in Germany.
    /// </summary>
    public class WeatherInGermany
    {
        /// <summary>
        /// Gets or sets de temperature Celsius.
        /// </summary>
        [Required]
        [Range(-100, 255, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets temperature Fahrenheit.
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets summary.
        /// </summary>
        [Required]
        public string Summary { get; set; }
    }
}