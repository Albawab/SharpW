namespace Identity_UserManager_Auhtentication.Authentication
{
    using Identity_UserManager_Auhtentication.Model;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;

    public class ApplicationUserManager : UserManager<GebruikerUserModel>
    {
        public ApplicationUserManager(IUserStore<GebruikerUserModel> store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<GebruikerUserModel> passwordHasher, 
            IEnumerable<IUserValidator<GebruikerUserModel>> userValidators, 
            IEnumerable<IPasswordValidator<GebruikerUserModel>> passwordValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            IServiceProvider services, 
            ILogger<UserManager<GebruikerUserModel>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            int y = 0;
            //this.PasswordHasher = passwordHasher;
        }
    }
}
