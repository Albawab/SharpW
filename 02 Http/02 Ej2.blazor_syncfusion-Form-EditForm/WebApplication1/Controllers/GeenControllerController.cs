using System;
using System.Collections.Generic;
using System.Linq;
using HenE_Application.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HenE_Application.Controllers
{
    [ApiController]
    [Route("GeenController")]
    public class GeenControllerController : ControllerBase
    {
        private static List<WeatherForecast> weatherForecasts = new List<WeatherForecast>();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public GeenControllerController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            var rng = new Random();
            int i = 1;
            weatherForecasts.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
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

        [HttpPost]
        public IActionResult Post(WeatherForecast forecast)
        {
            // oke, pak eerst het juiste element en update die

            WeatherForecast weatherForecast = weatherForecasts.Find(x => x.Id == forecast.Id);
            weatherForecasts.Add(weatherForecast);

            //weatherForecasts.a = forecast;

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(WeatherForecast forecast)
        {
            weatherForecasts[forecast.Id] = forecast;
            return Ok();
        }

        [HttpDelete("{id}", Name = "f")]
        public void Delete(int id)
        {
            weatherForecasts.RemoveAt(id);
        }
    }
}