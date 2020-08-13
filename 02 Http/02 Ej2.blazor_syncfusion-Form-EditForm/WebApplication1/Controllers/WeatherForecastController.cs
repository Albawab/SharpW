namespace HenE_Application.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using HenE_Application.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> weatherForecasts = new List<WeatherForecast>();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            this._logger = logger;

            var rng = new Random();
            int i = 1;
            weatherForecasts.AddRange(Enumerable.Range(1, 3).Select(index => new WeatherForecast
            {
                Id = i++,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            );
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return weatherForecasts.ToArray();
        }

        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<WeatherForecast> Get(int id)
        {
            List<WeatherForecast> forecasts = new List<WeatherForecast>();
            forecasts.Add(weatherForecasts[id]);
            return forecasts;
        }

/*        /// <summary>
        /// Create een nieuwe object.
        /// </summary>
        /// <param name="forecast">Een text die vanuit de kleint komt.</param>
        /// <returns>De antwoord.</returns>
        [HttpPost]
        public IActionResult Post([FromBody]string forecast)
         {
         int u = 0;

            // wat ga ik hier doen?
            if (forecast == string.Empty)
            {
                return this.BadRequest("Er is iets misgegaan.");
            }

            return this.Ok("Alles prima.");
        }*/

        /// <summary>
        /// Create een nieuwe object.
        /// </summary>
        /// <param name="forecast">Een text die vanuit de kleint komt.</param>
        /// <returns>De antwoord.</returns>
        [HttpPost]
        public IActionResult Post([FromBody]WeatherForecast forecast)
        {
            int u = 0;

            // wat ga ik hier doen?
            if (forecast == null)
            {
                return this.BadRequest("Er is iets misgegaan.");
            }

            weatherForecasts.Add(forecast);
            return this.Ok("Alles prima.");
        }

        [HttpPut("{id}", Name = "Update")]
        public IActionResult Put(int id, WeatherForecast forecast)
        {
            if (forecast == null)
            {
                return this.BadRequest();
            }

            foreach (WeatherForecast weatherForecast in weatherForecasts)
            {
                if (weatherForecast.Id == id)
                {
                    weatherForecast.Summary = forecast.Summary;
                }
            }

            return this.Ok();
        }

        [HttpDelete("{id}", Name = "Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                weatherForecasts.RemoveAt(id);
                return this.Ok();
            }
            catch
            {
                return this.BadRequest();
            }
        }

    }
}