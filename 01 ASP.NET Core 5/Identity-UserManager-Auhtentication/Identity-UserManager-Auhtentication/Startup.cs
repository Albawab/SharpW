using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Identity_UserManager_Auhtentication.DbContext;
using GenericServices.Setup;
using GenericServices.Configuration;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Identity_UserManager_Auhtentication.Model;
using System;
using Identity_UserManager_Auhtentication.Stores;
using Identity_UserManager_Auhtentication.Authentication;
using Microsoft.AspNetCore.Identity;
using Identity_UserManager_Auhtentication.Domein;

namespace Identity_UserManager_Auhtentication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public object JwtBearerDefaults { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthorization();
            services.AddAuthentication("Bearer")
            .AddJwtBearer("Bearer", options =>
            {
                options.RequireHttpsMetadata = false;
                options.Authority = this.Configuration["oidc:Authority"];
                options.TokenValidationParameters = new TokenValidationParameters { ValidateAudience = false };
            });

            services.AddDbContext<MyIdentityDbContext>(options =>
            {
                options.UseSqlServer(this.Configuration.GetConnectionString("AeolusAuth"));
            });

/*            services.ConfigureGenericServicesEntities(
                new GenericServicesConfig
                {
*//*                    DtoAccessValidateOnSave = true,  // This causes validation to happen on create/update via DTOs
                    DirectAccessValidateOnSave = true, // This causes validation to happen on direct create/update and delete*//*
                    NoErrorOnReadSingleNull = true, // When working with WebAPI you should set this flag. Responce then sends 404 on null result
                },
                typeof(MyIdentityDbContext))
                .ScanAssemblesForDtos(Assembly.GetAssembly(typeof(ExampleDtoForGettingAssembly)))
                .RegisterGenericServices(typeof(MyIdentityDbContext));*/

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Identity_UserManager_Auhtentication", Version = "v1" });
            });

            string connectionString = this.Configuration.GetConnectionString("AeolusAuth");

            services.AddDbContext<MyIdentityDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IPasswordHasher<GebruikerUserModel>, PasswordHasherV2>();

            services.AddIdentity<GebruikerUserModel, GebruikerUserModel>(
                options =>
                {
                    options.Password.RequireDigit = true;
                    options.Password.RequiredLength = 8;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequireLowercase = true;

                    // Lockout settings
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                    options.Lockout.MaxFailedAccessAttempts = 10;
                    options.Lockout.AllowedForNewUsers = true;

                    // User settings
                    options.User.RequireUniqueEmail = true;
                })
                .AddUserStore<ApplicationUserStore>()
                .AddUserManager<ApplicationUserManager>() // UserManager<AeolusUser>>()
                .AddRoleStore<ApplicationRoleStore>()
                .AddSignInManager<SignInManager<GebruikerUserModel>>()
                .AddDefaultTokenProviders();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Identity_UserManager_Auhtentication v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
