using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Extensions; 
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServerAspNetIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityServerAspNetIdentity.Services 
{ 
    public sealed class ProfileService : IProfileService
    {
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory;

        private readonly UserManager<ApplicationUser> userManager; 

        private readonly RoleManager<IdentityRole> roleManager;

        public ProfileService(
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager,
            IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory
        )
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.userClaimsPrincipalFactory = userClaimsPrincipalFactory;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context) 
        {
            Console.WriteLine("retrieving the profile data");

            string sub = context.Subject.GetSubjectId();
            ApplicationUser user = await userManager.FindByIdAsync(sub);
            ClaimsPrincipal userClaims = await userClaimsPrincipalFactory.CreateAsync(user);
             
            List<Claim> claims = userClaims.Claims.ToList();

            foreach(string claim in context.RequestedClaimTypes) { 
                Console.WriteLine("Requested claim: " + claim);
            }

            claims = claims.Where(claim => context.RequestedClaimTypes.Contains(claim.Type)).ToList();

            foreach(Claim claim in claims) { 
                Console.WriteLine("User Claims: " + claim);
            }

            if(userManager.SupportsUserRole)
            {
                IList<string> roles = await userManager.GetRolesAsync(user);
                foreach(var roleName in roles)
                {
                    IdentityRole role = await roleManager.FindByNameAsync(roleName);
                    if(role != null)
                    {
                        Console.WriteLine("The role is: " + role);

                        var roleClaim = await roleManager.GetClaimsAsync(role);

                        foreach(var c in roleClaim) {
                            Console.WriteLine("Role claim: " + c);
                        }

                        claims.AddRange(roleClaim);
                    }
                }
            }

            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context) 
        {
            string sub = context.Subject.GetSubjectId();
            ApplicationUser user = await userManager.FindByIdAsync(sub);
            context.IsActive = (user != null);
        }
    }
}