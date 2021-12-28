using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class RolePermission
    {
        public RolePermission()
        {
            RolePermissionApiResources = new HashSet<RolePermissionApiResource>();
        }

        public Guid Id { get; set; }
        public string Permissions { get; set; }
        public string Description { get; set; }
        public Guid RoleId { get; set; }

        public virtual AspNetRole Role { get; set; }
        public virtual ICollection<RolePermissionApiResource> RolePermissionApiResources { get; set; }
    }
}
