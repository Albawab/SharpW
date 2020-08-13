
using HenE_Server.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FormulierController : ControllerBase
    {
        private readonly AangifteDividendBelasting aangifteDividendBelasting = new AangifteDividendBelasting();
        [HttpGet]
        public string GetData()
        {
            return JsonConvert.SerializeObject(aangifteDividendBelasting);
        }
    }
}