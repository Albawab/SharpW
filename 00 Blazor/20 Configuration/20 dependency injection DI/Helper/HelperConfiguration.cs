using Microsoft.Extensions.Configuration;

namespace _20_dependency_injection_DI.Helper
{
    public class HelperConfiguration
    {

        public HelperConfiguration(IConfiguration configuration)
        {
            //["Email:another Child"]
            this.Email = configuration["Email"];
        }

        public string Email { get; set; }

    }
}
