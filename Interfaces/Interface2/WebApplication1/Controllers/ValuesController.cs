using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Interfaces;
using Loggers;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDoeIets _doeiets = null;
        private readonly ITellLocationOfLogFile tellLocationOfLogFile;
        
        public ValuesController(IDoeIets doeiets,ITellLocationOfLogFile locationOfLogFile)
        {
            _doeiets = doeiets;
            //_doeiets = new Persistor(new ConsoleLogger());
            this.tellLocationOfLogFile = locationOfLogFile;

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _doeiets?.DoeIets();
            tellLocationOfLogFile.LocationOfLogFile();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
