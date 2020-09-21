using _01_AddSingleton_AddTransient_AddScoped.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _01_AddSingleton_AddTransient_AddScoped.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiMetenController : ControllerBase
    {
        private readonly IKanMeten kanMeten;
        private readonly IKanMeten2 kanMeten2;
        public ApiMetenController(IKanMeten kanMeten,IKanMeten2 kanMeten2)
        {
            this.kanMeten = kanMeten;
           this.kanMeten2 = kanMeten2;
        }

        [HttpGet]
        public string Get()
        {
            return $"1- {kanMeten.ChangeFromMToCM(1)}\n {kanMeten2.ChangeFromMToCM2()}";
        }
    }
}
