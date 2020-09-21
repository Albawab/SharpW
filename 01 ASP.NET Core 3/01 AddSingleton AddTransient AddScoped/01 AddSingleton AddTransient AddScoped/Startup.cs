using _01_AddSingleton_AddTransient_AddScoped.Interfaces;
using _01_AddSingleton_AddTransient_AddScoped.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _01_AddSingleton_AddTransient_AddScoped
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<ICanSayHallo,SayHallo>();
            services.AddScoped<ICanSayHallo2,SayHallo2>();
            services.AddScoped<ICanSayHallo3,SayHallo3>();

            services.AddTransient<IKanMeten, ConvertToCM>();
            services.AddScoped<IKanMeten2, ConvertToCM2>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
