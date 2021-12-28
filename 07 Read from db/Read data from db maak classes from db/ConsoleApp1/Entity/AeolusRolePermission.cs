namespace HenE.Aeolus.Beveiliging.Domein
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class AeolusRolePermission
    {
        public AeolusRolePermission(string permissions, string description)
        {
            this.Id = Guid.NewGuid();
            this.Permissions = permissions;
            this.Description = description;
        }

        private AeolusRolePermission()
        {
            this.RolePermissionApiResources = new HashSet<RolePermissionApiResource>();
        }

        [Required]
        public Guid Id { get; private set; }

        [Required(AllowEmptyStrings = false)]
        public string Permissions { get; private set; }

        public string Description { get; private set; }

        [Required]
        public Guid RoleId { get; set; }

        public AeolusRole Role { get; set; }

        public ICollection<RolePermissionApiResource> RolePermissionApiResources { get; set; }
    }
}
