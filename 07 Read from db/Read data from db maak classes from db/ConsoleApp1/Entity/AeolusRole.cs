namespace HenE.Aeolus.Beveiliging.Domein
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class AeolusRole 
    {
        public AeolusRole(
            string id,
            string name,
            int tenantId,
            /*ICollection<AeolusRoleClaim> aspNetRoleClaims,*/
            ICollection<AeolusRolePermission> rolePermissions)
        {
            var validGuid = Guid.TryParse(id, out Guid guid) && guid != Guid.Empty;

            this.Id = validGuid ? guid : Guid.NewGuid();
            this.ConcurrencyStamp = Guid.NewGuid().ToString();
            this.Name = name;
            this.TenantId = tenantId;
            this.NormalizedName = this.Normalize(name);
            //this.RoleClaims = aspNetRoleClaims;
            this.RolePermissions = rolePermissions;
            /*            foreach (var rolePermission in this.RolePermissions)
                        {
                            rolePermission.Role = this;
                        }*/
        }

        private AeolusRole()
        {
            //this.RoleClaims = new HashSet<AeolusRoleClaim>();
            this.RolePermissions = new HashSet<AeolusRolePermission>();
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TenantId { get; set; }

        //public AeolusTenant Tenant { get; set; }

 //       public ICollection<AeolusRoleClaim> RoleClaims { get; private set; }

        public ICollection<AeolusRolePermission> RolePermissions { get; set; }


        public void Update(string name, int tenantId)
        {
            this.Name = name;
            this.NormalizedName = this.Normalize(name);
            this.TenantId = tenantId;
        }

        private string Normalize(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                return text.ToUpperInvariant();
            }

            return null;
        }
    }
}
