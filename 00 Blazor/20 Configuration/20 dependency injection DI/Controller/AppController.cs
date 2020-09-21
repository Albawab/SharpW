using _20_dependency_injection_DI.Interfaces;
using Microsoft.Extensions.Configuration;

namespace _20_dependency_injection_DI.Controller
{
    public class AppController : IAppController
    {
        public string Email { get; set; }
        public AppController(IConfiguration configuration)
        {
            this.Email = configuration.GetSection("Email").Value;
        }
    }
}
