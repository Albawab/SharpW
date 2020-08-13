// <copyright file="WeatherForecast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Application.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Hier staat de gegevens van de weather.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets de id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or setss de date.
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

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

        /// <summary>
        /// Gets or sets de naam van een persoon.
        /// </summary>
        [Required]
        [FirsName(EerstNaam = StringLength.Een, ErrorMessage ="Er is iets misgegaan.")]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets De email van een persoon.
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the weather status.
        /// </summary>
        public bool IsNiceWeather { get; set; }

        /// <summary>
        /// Gets or sets the skills van een persoon.
        /// </summary>
        public string[] Skills { get; set; }

        /// <summary>
        /// Gets or sets the weather of Germany.
        /// </summary>
        public WeatherInGermany Germany { get; set; }

        /// <summary>
        /// Gets or sets a weather of Syria.
        /// </summary>
        public WeatherInSyria Syria { get; set; }

        /// <summary>
        /// Gets or sets a weather of USA.
        /// </summary>
        public WeatherInAmerica USA { get; set; }
    }
}
