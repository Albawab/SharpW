using Identity_UserManager_Auhtentication.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_UserManager_Auhtentication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly UserManager<GebruikerUserModel> _userManager;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, UserManager<GebruikerUserModel> userManager)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GebruikerUserModel> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new GebruikerUserModel
            {
                Id = Guid.NewGuid(),
                UserName ="Naam"
            })

            .ToArray();
        }
        
        [HttpPost]
        public IEnumerable<GebruikerUserModel> Post()
        {
            GebruikerUserModel gebruikerUserModel = new GebruikerUserModel();
            var user = _userManager.CreateAsync(gebruikerUserModel);
            return Enumerable.Range(1, 5).Select(index => new GebruikerUserModel
            {
                Id = Guid.NewGuid(),
                UserName ="Naam"
            })

            .ToArray();
        }
    }
}
