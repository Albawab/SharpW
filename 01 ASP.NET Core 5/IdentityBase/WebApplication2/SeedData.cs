using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2
{
    public class SeedData
    {
        public async static void EnsureSeedData(string connectionString)
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(connectionString));

            services.AddIdentity<MyExtendedIdentityUser, IdentityRole<Guid>>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();


            var serviceProvider = services.BuildServiceProvider();
            var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
            context.Database.Migrate();


            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<MyExtendedIdentityUser>>();

            // Add Role
            var role = new IdentityRole<Guid>()
            {
                 Id = Guid.NewGuid(),
                 Name = "admin",
            };

            await roleManager.CreateAsync(role);

            await roleManager.AddClaimAsync(role, new Claim(ClaimTypes.Name, "add.role"));

            //Add User.
            var user = new MyExtendedIdentityUser()
            {
                Id = Guid.NewGuid(),
                UserName = "user",
                Email = $"josSmith1@email.com",
                EmailConfirmed = true,
            };
            await userManager.CreateAsync(user, "Pass123$");

            await userManager.AddToRoleAsync(user, role.Name);
            await userManager.AddClaimAsync(user, new Claim(ClaimTypes.Authentication, user.UserName));







            /*            for (int i = 0; i <= 50; i++)
                        {
                            MyExtendedIdentityAspNetUserRole myExtendedIdentityAspNetUserRole = new MyExtendedIdentityAspNetUserRole()
                            {
                                UserId = Guid.NewGuid(),
                            };
                            MyExtendedIdentityRoleClaim myExtendedIdentityRoleClaim = new MyExtendedIdentityRoleClaim()
                            {
                                Id = i,
                                RoleId = Guid.NewGuid(),
                            };

                            MyExtendedIdentityUserClaim myExtendedIdentityUserClaim = new MyExtendedIdentityUserClaim()
                            {
                                Id = i,
                                UserId = Guid.NewGuid(),
                            };
                            MyExtendedIdentityAspNetRole myExtendedIdentityAspNetRole = new MyExtendedIdentityAspNetRole()
                            {
                                Id = Guid.NewGuid(),
                                Name = $"Role{i}",
                            };

                        }*/

            /*var userMgrAspNetUserClaims = scope.ServiceProvider.GetRequiredService<UserManager<MyExtendedIdentityUserClaims>>();
            var jos = userMgr.FindByNameAsync("Jos").Result;
            if (jos == null)
            {
                jos = new MyExtendedIdentityUser
                {                    
                    UserName = "jos",
                    Email = "josSmith@email.com",
                    EmailConfirmed = true,
                };
                var result = userMgr.CreateAsync(jos, "Pass123$").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }*/
            /*                Log.Debug("jos created");*/
            /*}
            else
            {
                Log.Debug("jos already exists");
            }
*/


        }
    }
}
