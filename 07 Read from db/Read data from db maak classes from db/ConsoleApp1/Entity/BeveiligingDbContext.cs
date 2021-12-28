namespace HenE.Aeolus.Beveiliging.DbContext
{
    using System;
    using HenE.Aeolus.Beveiliging.Domein;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// De BeveiligingDbContext combineert een aangepaste IdentityDbContext (op basis van Guids en met Multi-Tenancy ondersteuning)
    /// met de bestaande ConfigDbContext en PersistedGrantsDbContext van IdentityServer4.
    /// </summary>
    public class BeveiligingDbContext : DbContext
    {
        public BeveiligingDbContext(DbContextOptions<BeveiligingDbContext> options)
            : base(options)
        {
        }

        public BeveiligingDbContext()
        {
        }


        // API Resource Entities
        public DbSet<AeolusApiResource> ApiResources { get; set; }

        // AspNet Entities (Microsoft IdentityDbContext)
        // Met naamgeving "Application" ipv "AspNet" voor de entities (enkelvoud) en gebruik in Beveiliging.Service
        // En met naamgeving "AspNet" voor de tabellen (meervoud) en gebruik in Beveiliging.API
        public DbSet<AeolusRole> Roles { get; set; }

        public DbSet<AeolusRoleClaim> RoleClaims { get; set; }
               
        // RolePermissions
        public DbSet<AeolusRolePermission> RolePermissions { get; set; }

        public DbSet<RolePermissionApiResource> RolePermissionApiResources { get; set; }

        // Tenants
        //public DbSet<AeolusTenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*builder.Entity<AeolusApiResource>(b =>
            {
                b.ToTable("ApiResources");

                b.HasKey("Id");

                b.HasIndex(e => e.Name)
                    .IsUnique();

                b.Property(e => e.Description).HasMaxLength(1000);

                b.Property(e => e.DisplayName).HasMaxLength(200);

                b.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });
            */

            builder.Entity<AeolusRole>(b =>
            {
                b.ToTable("AspNetRoles");

                b.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                b.Property(e => e.Id).ValueGeneratedNever();

                b.Property(e => e.Name).HasMaxLength(256);

                b.Property(e => e.NormalizedName).HasMaxLength(256);
            });


            /*builder.Entity<AeolusRoleClaim>(b =>
            {
                b.ToTable("AspNetRoleClaims");

                b.HasIndex(e => e.RoleId);

                b.Property(e => e.RoleId).IsRequired();

                b.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });
            */

            builder.Entity<AeolusRolePermission>(b =>
            {
                b.ToTable("RolePermissions");

                b.HasIndex(e => e.Id, "IX_RolePermissions_Id");

                b.HasIndex(e => e.RoleId, "IX_RolePermissions_RoleId");



                //b.Property(e => e.Permissions).IsRequired();

                b.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId);

                b.Property(e => e.Id).ValueGeneratedNever();

                b.HasMany(d => d.RolePermissionApiResources)
                    .WithOne(a => a.AeolusRolePermission)
                    .HasForeignKey(d => d.RolePermissionId);

            });

            builder.Entity<RolePermissionApiResource>(b =>
            {
                b.ToTable("RolePermissionApiResources");

                b.HasKey(e => new { e.ApiResourceId, e.RolePermissionId });

                b.HasIndex(e => e.RolePermissionId);

                /*b.HasOne(d => d.RolePermission)
                    .WithMany(p => p.RolePermissionApiResources)
                    .HasForeignKey(d => d.RolePermissionId)
                    .OnDelete(DeleteBehavior.Cascade);
                */

                b.HasOne(d => d.AeolusApiResource)
                    .WithMany(p => p.RolePermissionApiResources)
                    .HasForeignKey(d => d.ApiResourceId)
                    /*.OnDelete(DeleteBehavior.Cascade)*/;
            });

            /*builder.Entity<AeolusTenant>(b =>
            {
                b.ToTable("Tenants");

                b.HasKey(e => e.Id);

                b.Property(e => e.Id).IsRequired();

                b.Property(e => e.Name).IsRequired();
            });
            */
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=SQLDEVELOP\\Sql2017;Initial Catalog=Aeolus_Beveiliging;User ID=sa;Password=Sebas0412;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150));
        }
    }
}
