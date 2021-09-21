using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IdentityServerAspNetIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// Added the following lines
using System.Security.Claims; // need for claims API
using IdentityModel; // needed for JwtClaimTypes
using Serilog;  // used for Log statements
// ----------------------------------------------------

namespace IdentityServerAspNetIdentity.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        // Added the following line
        // This is inserted using dependency injection. Used to access user claims, 
        // which are stored in the AspNetUserClaims table.
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipalFactory;
        // ----------------------------------------------------


        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            // Added the following line
            IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory
            // ----------------------------------------------------
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            // Added the folloing line
            _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
            // ----------------------------------------------------
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            // Added the following lines
            // Used to pass data to and from the view.
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Forename")]
            public string Forename { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Suname")]
            public string Surname { get; set; }

            [Required]
            [Display(Name = "Registered On")]
            [DataType(DataType.Date)]
            public DateTime RegisteredOn { get; set; }
            // ----------------------------------------------------
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            // Added the following lines
            // Access the user claims factory to get information about the claims for the user
            ClaimsPrincipal userClaims = await _userClaimsPrincipalFactory.CreateAsync(user);
            List<Claim> claims = userClaims.Claims.ToList();

            foreach(Claim claim in claims) { 
                Log.Debug("Stage 1: User Claims: " + claim);
            }
            // ----------------------------------------------------

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                // Added the following lines
                // First two lines are getting values from the Claims and the third item 
                // is getting data from the ApplicationUser class.
                Forename = claims.Single(claim => claim.Type == JwtClaimTypes.GivenName).Value,
                Surname = claims.Single(claim => claim.Type == JwtClaimTypes.FamilyName).Value,
                RegisteredOn = user.RegisteredOn
                // ----------------------------------------------------
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            // Added the following lines
            // Update any claims
            ClaimsPrincipal userClaims = await _userClaimsPrincipalFactory.CreateAsync(user);
            List<Claim> claims = userClaims.Claims.ToList();

            Claim claim = claims.Single(claim => claim.Type == JwtClaimTypes.GivenName); 
            if(Input.Forename != claim.Value) 
            {
                var result = await _userManager.RemoveClaimAsync(user, claim);
                if(!result.Succeeded) 
                {
                    Log.Error("Error - unable to remove claim");
                    throw new Exception($"Unable to remove claim for {JwtClaimTypes.GivenName}");
                }
                else
                {
                    Log.Debug($"Removed claim {JwtClaimTypes.GivenName}");
                }

                result = await _userManager.AddClaimAsync(user, new Claim(JwtClaimTypes.GivenName, Input.Forename));
                if(!result.Succeeded) 
                {
                    Log.Error("Error - unable to add claim");
                    throw new Exception($"Unable to add claim for {JwtClaimTypes.GivenName}");
                }
                else
                {
                    Log.Debug($"Added claim {JwtClaimTypes.GivenName}");
                }
            }

            claim = claims.Single(claim => claim.Type == JwtClaimTypes.FamilyName); 
            if(Input.Surname != claim.Value) 
            {
                var result = await _userManager.RemoveClaimAsync(user, claim);
                if(!result.Succeeded) 
                {
                    Log.Error("Error - unable to remove claim");
                    throw new Exception($"Unable to remove claim for {JwtClaimTypes.FamilyName}");
                }
                else
                {
                    Log.Debug($"Removed claim {JwtClaimTypes.FamilyName}");
                }

                result = await _userManager.AddClaimAsync(user, new Claim(JwtClaimTypes.FamilyName, Input.Surname));
                if(!result.Succeeded) 
                {
                    Log.Error("Error - unable to add claim");
                    throw new Exception($"Unable to add claim for {JwtClaimTypes.FamilyName}");
                }
                else
                {
                    Log.Debug($"Added claim {JwtClaimTypes.FamilyName}");
                }
            }

            // ----------------------------------------------------
            

            // Added the following lines
            // Update any relevant properties on the Identity User

            if (Input.RegisteredOn != user.RegisteredOn)
            {
                user.RegisteredOn = Input.RegisteredOn;
            }

            await _userManager.UpdateAsync(user);

            // ----------------------------------------------------
            
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
