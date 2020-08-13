// <copyright file="WeatherForecast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    using System;

    /// <summary>
    /// De weather cast.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets .
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Summary { get; set; }
    }
}
