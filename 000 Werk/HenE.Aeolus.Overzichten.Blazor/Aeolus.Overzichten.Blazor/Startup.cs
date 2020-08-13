// <copyright file="Startup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Aeolus.Overzichten.Blazor
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Net.Http;
    using Aeolus.Blazor.Common.Body.Interfaces;
    using Aeolus.Blazor.Common.Navigatie.Services;
    using Aeolus.Blazor.Overzichten.Mockups;
    using Aeolus.Overzichten.Blazor.Mockups;
    using global::Aeolus.Blazor.Common.Navigatie.Interfaces;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Localization;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Syncfusion.Blazor;

    /// <summary>
    /// Startup class.
    /// </summary>
    public class Startup
    { /// <summary>
      /// Initializes a new instance of the <see cref="Startup"/> class.
      /// </summary>
      /// <param name="configuration">configuration.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets Configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940.
        /// </summary>
        /// <param name="services">services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSyncfusionBlazor();
            services.AddSingleton<HttpClient>();

            services.AddSingleton<INavigatieService>(new InternalNavigatieService());
            services.AddSingleton<IBodyService>(new InternalToolsMenuService());

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.Configure<RequestLocalizationOptions>(options =>
            {
                // define the list of cultures your app will support
                var supportedCultures = new List<CultureInfo>()
            {
                new CultureInfo("nl"),
            };

                // set the default culture
                options.DefaultRequestCulture = new RequestCulture("nl");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders = new List<IRequestCultureProvider>()
                {
                 new QueryStringRequestCultureProvider(),
                };
            });
            services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(AppLocalizer));

            /*            services.AddDbContext<HenE_GridContext>(options =>
                                options.UseSqlServer(Configuration.GetConnectionString("HenE_GridContext")));*/
        }

        /// <summary>
        ///  This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">app.</param>
        /// <param name="env">env.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjI2NjE3QDMxMzgyZTMxMmUzMEFwaHo2SnBnNUoyWDdRaXpGM2NpS0duSWRHNE90TUFUWFlHd0tReHBFL289");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            JsonNavigationServer a = new JsonNavigationServer();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseRequestLocalization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();

                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
