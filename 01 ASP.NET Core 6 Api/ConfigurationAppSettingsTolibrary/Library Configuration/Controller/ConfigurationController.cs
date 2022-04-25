using Library_Configuration.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Configuration.Controller
{
    public class ConfigurationController : IControlConfiguration
    {

        public ConfigurationController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",optional:false);
            IConfiguration config = builder.Build();
            string tets = config.GetValue<string>("Test");

        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
