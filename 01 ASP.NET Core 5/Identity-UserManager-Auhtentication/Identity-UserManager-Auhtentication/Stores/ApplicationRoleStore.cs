namespace Identity_UserManager_Auhtentication.Stores
{
    using System;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using Identity_UserManager_Auhtentication.DbContext;
    using Identity_UserManager_Auhtentication.Domein;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

        public class ApplicationRoleStore : RoleStore<AeolusRole, MyIdentityDbContext, Guid, AeolusUserRole, AeolusRoleClaim>
    {
        public ApplicationRoleStore(MyIdentityDbContext context)
          : base(context)
        {
        }

        public int TenantId { get; set; }

        public override Task<IdentityResult> CreateAsync(AeolusRole role, CancellationToken cancellationToken = default)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            return base.CreateAsync(role, cancellationToken);
        }

        protected override AeolusRoleClaim CreateRoleClaim(AeolusRole role, Claim claim)
        {
            return new AeolusRoleClaim
            {
                RoleId = role.Id,
                ClaimType = claim.Type,
                ClaimValue = claim.Value,
            };
        }
    }
}
