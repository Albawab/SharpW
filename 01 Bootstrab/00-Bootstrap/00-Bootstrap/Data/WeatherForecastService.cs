using System;

namespace _00_Bootstrap.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecast GetAuthor(WeatherForecast WeatherForecast)
        {
            Console.WriteLine(WeatherForecast.Name);
           return new WeatherForecast() { Name = "Abdul" };
        }

    }
}
