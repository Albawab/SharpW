using _01_AddSingleton_AddTransient_AddScoped.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _01_AddSingleton_AddTransient_AddScoped.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiSayHalloController : ControllerBase
    {
        private readonly ICanSayHallo2 canSayHallo2;
        private readonly ICanSayHallo canSayHallo1;
        private readonly ICanSayHallo3 canSayHallo3;
        private readonly ISayHallo4 sayHallo4;
        public ApiSayHalloController(ICanSayHallo canSayHallo, ICanSayHallo2 sayHallo2,ICanSayHallo3 canSayHallo3, ISayHallo4 sayHallo4)
        {
            this.canSayHallo1 = canSayHallo;
            this.canSayHallo2 = sayHallo2;
            this.canSayHallo3 = canSayHallo3;
            this.sayHallo4 = sayHallo4;
        }

        [HttpGet]
        public string GetHallo()
        {
            return $"{canSayHallo1.SayHallo()}\n {canSayHallo2.Say2()} \n{canSayHallo3.Say3()} \n {sayHallo4.SayH4()}";
        }
    }
}
