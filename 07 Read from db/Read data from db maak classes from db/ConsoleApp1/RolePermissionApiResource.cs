namespace HenE.Aeolus.Beveiliging.Domein
{
    using System;
    using System.ComponentModel.DataAnnotations;


    public class RolePermissionApiResource
    {
        public RolePermissionApiResource(int apiResourceId, Guid rolePermissionId)
        {
            this.ApiResourceId = apiResourceId;
            this.RolePermissionId = rolePermissionId;
        }

        [Required]
        public Guid RolePermissionId { get; set; }

        [Required]
        public int ApiResourceId { get; private set; }

        public AeolusRolePermission AeolusRolePermission { get; set; }

        public AeolusApiResource AeolusApiResource { get; set; }
    }
}
