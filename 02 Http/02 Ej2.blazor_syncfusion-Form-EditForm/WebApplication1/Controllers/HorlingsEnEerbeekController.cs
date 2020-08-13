using Microsoft.AspNetCore.Mvc;

namespace HenE_Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HorlingsEnEerbeekController : ControllerBase
    {
        [HttpGet("{id}")]
        public string welkom(int id)
        {
            return "Welkom bij Horlings & Eerbeek ";
        }

        [HttpGet]
        public IActionResult TotZiens()
        {
            return this.Ok();
        }

        [HttpPost]
        public IActionResult PostItem()
        {
            return this.Ok();
        }
    }
}