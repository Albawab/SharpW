using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _16_Configuration_render_modeOneTimeTwoTimes
{
    public class ConfigurationInstellingen
    {
        private IConfiguration configuration;

        public ConfigurationInstellingen()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            this.configuration = builder.Build();
        }

        public string GetInstelling(string name)
        {
            string appSettings = this.configuration[name];
            return appSettings;
        }
    }
}
