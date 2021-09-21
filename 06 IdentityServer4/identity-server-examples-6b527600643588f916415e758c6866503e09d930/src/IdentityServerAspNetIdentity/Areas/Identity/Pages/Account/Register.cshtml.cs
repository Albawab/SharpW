using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using IdentityServerAspNetIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
// Added the following lines
using IdentityModel; // for JwtClaimTypes
using System.Security.Claims; // for Claims API
// ------------------------------------------------

namespace IdentityServerAspNetIdentity.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        
        // Commented out - would need more work to setup 
        //private readonly IEmailSender _emailSender;
        // -------------------------------------------------

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger) 
            // Commented out
            // ,
            //IEmailSender emailSender)
            // --------------------------------------------------
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            // Commented out 
            //_emailSender = emailSender;
            // --------------------------------------------------
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            // Added the following lines 
            // Added to allow transfer of data to and from the view 
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
            // --------------------------------------------------
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { 
                    UserName = Input.Email,
                    Email = Input.Email,
                    // Added following line 
                    // Maps data onto the additional property for the field
                    RegisteredOn = Input.RegisteredOn
                    // --------------------------------------------------
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    // Added following lines
                    // Used to register claims for the user from the input form 
                    var claimResult = _userManager.AddClaimsAsync(user, new Claim[]{
                        new Claim(JwtClaimTypes.Name, $"{Input.Forename} {Input.Surname}"),
                        new Claim(JwtClaimTypes.GivenName, Input.Forename),
                        new Claim(JwtClaimTypes.FamilyName, Input.Surname),
                    }).Result;
                    if (!claimResult.Succeeded)
                    {
                        throw new Exception(claimResult.Errors.First().Description);
                    }
                    // --------------------------------------------------

                    // Removed following lines 
                    // Setting up email is more work than needed for now
                    // var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    // code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    // var callbackUrl = Url.Page(
                    //     "/Account/ConfirmEmail",
                    //     pageHandler: null,
                    //     values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                    //     protocol: Request.Scheme);

                    // await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //     $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    // if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    // {
                    //     return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    // }
                    // else
                    // {
                    // --------------------------------------------------
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    // Removed following line    
                    // }
                    // --------------------------------------------------
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
