# Identity Server 4 with Identity

This project was setup following the [Identity Server template for working with ASP.NET Core Identity](https://identityserver4.readthedocs.io/en/latest/quickstarts/6_aspnet_identity.html). Some modifications were made to make use of roles. They were all in the main banch. 

This file talks about changes made since that initial version used for discussion. It covers modifications to make use of more of the Identity features. This involves: 

* Using the `aspnet-codegenerator` tool to add a set of RazorPages to the project to help manage the identity data. 
* Modifying the existing `ApplicationUser` class to add custom properties. 
* Linking the Claims information to the Identity forms so that the Given Name and Family Name are used in a way that works with the OpenID Connect facilities in the Identity Server.

## Scaffolding

You can look at the options for the Identity Scaffolding features using:

```
dotnet aspnet-codegenerator identity --help
```

List the files that can be created using the scaffolding feature.

```
dotnet aspnet-codegenerator identity -lf
```

At the time of writing, the list of files were:

```
File List:
Account._StatusMessage
Account.AccessDenied
Account.ConfirmEmail
Account.ConfirmEmailChange
Account.ExternalLogin
Account.ForgotPassword
Account.ForgotPasswordConfirmation
Account.Lockout
Account.Login
Account.LoginWith2fa
Account.LoginWithRecoveryCode
Account.Logout
Account.Manage._Layout
Account.Manage._ManageNav
Account.Manage._StatusMessage
Account.Manage.ChangePassword
Account.Manage.DeletePersonalData
Account.Manage.Disable2fa
Account.Manage.DownloadPersonalData
Account.Manage.Email
Account.Manage.EnableAuthenticator
Account.Manage.ExternalLogins
Account.Manage.GenerateRecoveryCodes
Account.Manage.Index
Account.Manage.PersonalData
Account.Manage.ResetAuthenticator
Account.Manage.SetPassword
Account.Manage.ShowRecoveryCodes
Account.Manage.TwoFactorAuthentication
Account.Register
Account.RegisterConfirmation
Account.ResetPassword
Account.ResetPasswordConfirmation
```

For the purposes of this example, the following pages were created:

```
Account._StatusMessage
Account.Manage._Layout
Account.Manage._ManageNav
Account.Manage._StatusMessage
Account.Manage.ChangePassword
Account.Manage.DownloadPersonalData
Account.Manage.Email
Account.Manage.Index
Account.Manage.PersonalData
Account.Register
```

Scaffolding the pages for Account Registration and Managing the User data can be done with the following.

```
dotnet aspnet-codegenerator identity -dc IdentityServerAspNetIdentity.Data.ApplicationDbContext -sqlite -fi "Account.Register;Account.Manage.Index;Account._StatusMessage;Account.Manage._Layout;Account.Manage._ManageNav;Account.Manage._StatusMessage;Account.Manage.ChangePassword;Account.Manage.DownloadPersonalData;Account.Manage.Email;Account.Manage.PersonalData"
```

Note, that there is a new Area added to the project. This is a subset of the site. It is under `Areas/Identity`. In terms of URLs to access that content, it will be `{site}/Identity/{pages}`. 

## Support for Razor pages

Lines 35 and 87 were added in `Startup.cs` so that the RazorPages are part of the pipeline for page requests. 

## Adding a standard layout

The generated pages are Razor Pages, so a bit different to what we have looked at for MVC. 

Each of the `cshtml` views (excluding the ones with the underscore prefix) are modified by adding a Layout line to the early part of the file. You will see the following have been inserted. The HTML comments (`<!-- --->`) have been added to indicate areas that have been added. 

```
<!-- added the following -->
Layout = "_Layout";
<!-- end of added -->
```
## Adding custom profile data

The `ApplicationUser` class has three properties. After applying a migration, the fields are added to the `AspNetUsers` database table. With hindsight, the properties for `Forename` and `Surname` aren't needed. Given that we are using `Sqlite` in this example, there isn't an easy way to drop those columns; it would need to make a copy of AspNetUsers, make the change and delete the original table before renaming to be back to the same. So, they have been left in the example for now. 

The `Forename` and `Surname` fields are better inserted as Claims for the user. The code in `Register.cshtml.cs` and `Index.cshtml.cs` both make use of the Claims instead of the `Forename` and `Surname` fields.

## Changes to views

To support the new profile data and claims, there are some fields added to the files `Index.cshtml` and `Register.cshtml`. There are comments in the file to highlight which fields have been added. These provide places for the Forename, Surname and Registered On fields. 

## Changes to the model/controller files

The `.cshtml.cs` files for Index and Register have been modified too. There is an InputModel class in each file. The fields for Forename, Surname and Registered On items are in the classes to enable transfer to and from the view files. 

In `Index.cshtml`, the `LoadAysnc` method has been modified to read Claims using the `IUserClaimsPrincipalFactory<ApplicationUser>` (passed to the class using DependencyInjection). 

To access the list of claims, the following lines are used.

```
ClaimsPrincipal userClaims = await _userClaimsPrincipalFactory.CreateAsync(user);
List<Claim> claims = userClaims.Claims.ToList();
```

Accessing the value for the claim is done with the following statement.

```
claims.Single(claim => claim.Type == JwtClaimTypes.GivenName).Value
```

The `OnPostAsync` method has also been changed to store the `Forename` and `Surname` from the InputModel to Claims and the `RegisteredOn` from the InputModel to the ApplicationUser. 

Part of the code to handle the claims is shown below. To update a claim, it is removed and then readded with the new value.  

```
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
```

In `Register.cshtml`, the `OnPostAsync` method was modified to create Claims for a new user, following the example from the `SeedData.cs` file.  

```
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
```

## Running the example

The example code will still work with the calling client. There are now links at the top for the Identity Server page to go to the Register page. After login is complete (from the MvcClient app), returning to the Identity Server code will then allow you to see the pages to manage the user data and passwords. 

## Resources

The following resources from the Microsoft documentation are relevant for this example:

* [Scaffold Identity in ASP.NET Core Projects](https://docs.microsoft.com/en-gb/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio) - using the `dotnet aspnet-codegenerator` tool to created the Idenitity pages to the project.
* [Add, download, and delete custom user data to Identity in an ASP.NET Core project](https://docs.microsoft.com/en-gb/aspnet/core/security/authentication/add-user-data?view=aspnetcore-3.1&tabs=netcore-cli) - this example looks at modifying an IdentityUser subclass and adding in properties.
* [Account confirmation and password recovery in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-5.0&tabs=visual-studio#require-email-confirmation) - this article talks about configuring email to use a 3rd party service (SendGrid). The example code in this project does not use those features. 