namespace Identity_UserManager_Auhtentication.Stores
{
    using System;
    using Identity_UserManager_Auhtentication.DbContext;
    using Identity_UserManager_Auhtentication.Domein;
    using Identity_UserManager_Auhtentication.Model;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class ApplicationUserStore : UserStore<GebruikerUserModel, AeolusRole, MyIdentityDbContext, Guid, AeolusUserClaim, AeolusUserRole, AeolusUserLogin, AeolusUserToken, AeolusRoleClaim>
    {
        public ApplicationUserStore(MyIdentityDbContext context)
          : base(context)
        {
        }
    }
}
