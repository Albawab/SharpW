using ApiInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiInjection.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IZegHallo zegHallo;

        private IApi2 api2;

        public ApiController(IZegHallo zegHallo, IApi2 api2)
        {
            this.zegHallo = zegHallo;
           this.api2 = api2;
        }

        [HttpGet]
        public string Hallo()
        {
            return $"{this.zegHallo.ZegHallo()}; aPI2  {api2.Hallo()}";
        }
    }


    public class Api2 : IApi2
    {
        private readonly IZegHallo zegHallo;

        public Api2(IZegHallo zegHallo)
        {
            this.zegHallo = zegHallo;
        }

        public string Hallo()
        {
            return this.zegHallo.ZegHallo();
        }


    }
}
