// <copyright file="WeatherForecast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace HenE_Application.Data
{
    public class WeatherInSyria
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