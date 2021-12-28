namespace HenE.Aeolus.Beveiliging.Domein
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class AeolusApiResource 

    {
        public AeolusApiResource(int id, string name, string displayName)
        {
            this.Id = id;
            this.Name = name;
            this.DisplayName = displayName;
/*
            this.Description = description;
            this.Enabled = enabled ?? true;
            this.AllowedAccessTokenSigningAlgorithms = allowedAccessTokenSigningAlgorithms;
            this.NonEditable = nonEditable ?? false;
            this.ShowInDiscoveryDocument = showInDiscoveryDocument ?? true;
            this.UserClaims = apiResourceClaims;
            this.Properties = apiResourceProperties;
            this.Scopes = apiResourceScopes;
            this.Secrets = apiResourceSecrets;
            this.Created = DateTime.Now;
*/
        }

        [Required]
        public int Id { get; private set; }

        [Required]
        public bool Enabled { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string DisplayName { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        public DateTime? LastAccessed { get; set; }

        public string AllowedAccessTokenSigningAlgorithms { get; set; }

        [Required]
        public bool NonEditable { get; set; }

        [Required]
        public bool ShowInDiscoveryDocument { get; set; }


        public ICollection<RolePermissionApiResource> RolePermissionApiResources { get; set; }

        public void Update(
            bool? enabled,
            string name,
            string displayName,
            string description,
            string allowedAccessTokenSigningAlgorithms,
            bool? nonEditable,
            bool? showInDiscoveryDocument)
        {
            if (enabled.HasValue)
            {
                this.Enabled = enabled.Value;
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                this.Name = name;
            }

            if (!string.IsNullOrWhiteSpace(displayName))
            {
                this.DisplayName = displayName;
            }

            if (!string.IsNullOrWhiteSpace(description))
            {
                this.Description = description;
            }

            if (!string.IsNullOrWhiteSpace(allowedAccessTokenSigningAlgorithms))
            {
                this.AllowedAccessTokenSigningAlgorithms = allowedAccessTokenSigningAlgorithms;
            }

            if (nonEditable.HasValue)
            {
                this.NonEditable = nonEditable.Value;
            }

            if (showInDiscoveryDocument.HasValue)
            {
                this.ShowInDiscoveryDocument = showInDiscoveryDocument.Value;
            }

            this.HandleUpdated();
        }

        private void HandleUpdated()
        {
            this.Updated = DateTime.Now;
        }
    }
}
