namespace HenE.Aeolus.Beveiliging.Domein
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class AeolusRoleClaim 
    {
        public AeolusRoleClaim(string claimType, string claimValue)
        {
            this.ClaimType = claimType;
            this.ClaimValue = claimValue;
        }

        public AeolusRoleClaim()
        {
        }

        [Required]
        public int Id { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        public AeolusRole Role { get; private set; }
    }
}
