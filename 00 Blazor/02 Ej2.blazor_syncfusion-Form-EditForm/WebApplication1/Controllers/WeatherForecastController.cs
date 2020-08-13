namespace HenE_Application.Controllers
{
    using System;
    using System.Collections.Generic;
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
            /*            int i = 1;
                        weatherForecasts.AddRange(Enumerable.Range(1, 3).Select(index => new WeatherForecast
                        {
                            Id = i++,
                            Date = DateTime.Now.AddDays(index),
                            TemperatureC = rng.Next(-20, 55),
                            Summary = Summaries[rng.Next(Summaries.Length)]
                        })
                        );*/
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            /*            Response.Clear();
                        Response.ContentType = "application/pdf";*/
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

        [HttpDelete("{id}", Name = "Delete")]
        public IActionResult Delete(int id)
        {
            if (weatherForecasts.Count == 0)
            {
                return BadRequest();
            }
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

        [HttpPut("{id}", Name = "Update")]
        public IActionResult Put(int id, WeatherForecast forecast)
        {
            if (forecast == null)
            {
                return this.BadRequest();
            }
            if (weatherForecasts.Count == 0)
            {
                return this.BadRequest();
            }

            weatherForecasts[id] = forecast;

            return this.Ok();
        }

/*        /// <summary>
        /// Update een deel van de items.
        /// </summary>
        /// <returns>Heeft de items geupdate of niet.</returns>
        [HttpPatch("{id}")]
        public ActionResult UpdateItem(int id, [FromBody]JsonPatchDocument<WeatherForecast> forecast)
        {
            if (forecast == null)
            {
                return this.BadRequest();
            }

            if (weatherForecasts.Count == 0)
            {
                return this.BadRequest();
            }

            WeatherForecast weatherForecast = new WeatherForecast();

            forecast.ApplyTo(weatherForecast);

            //forecast.ApplyTo();

            *//*  weatherForecasts.Find(p => p.Id == id).Id = forecast.Id;*//*

            return this.Ok();
        }*/
    }
}