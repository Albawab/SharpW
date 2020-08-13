using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PersoonLibrary;

namespace ApiJson.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersoonController : ControllerBase
    {

        [HttpGet("{id}")]
        public string GetPersonen(int id)
        {
            if (id ==1)
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                return JsonConvert.SerializeObject(
                    new List<Persoon> {
                new Student("A", "30", true),
                new Employee("G","29",false)
                    }, settings//<<<<<<<<===============================================================================================================
                    );
            }
            return null;
        }
    }
}
