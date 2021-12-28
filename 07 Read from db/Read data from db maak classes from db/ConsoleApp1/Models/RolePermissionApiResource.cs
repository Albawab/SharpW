using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class RolePermissionApiResource
    {
        public Guid RolePermissionId { get; set; }
        public int ApiResourceId { get; set; }

        public virtual ApiResource ApiResource { get; set; }
        public virtual RolePermission RolePermission { get; set; }
    }
}
