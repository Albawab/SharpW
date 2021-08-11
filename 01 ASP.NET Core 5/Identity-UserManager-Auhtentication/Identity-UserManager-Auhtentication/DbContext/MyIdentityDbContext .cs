using Identity_UserManager_Auhtentication.Domein;
using Identity_UserManager_Auhtentication.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Identity_UserManager_Auhtentication.DbContext
{
    public class MyIdentityDbContext : IdentityDbContext<GebruikerUser, AeolusRole, Guid, AeolusUserClaim, AeolusUserRole, AeolusUserLogin, AeolusRoleClaim, AeolusUserToken>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options)
    : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GebruikerUserModel>(b =>
            {
                b.ToTable("ApiResources");

                b.HasKey("Id");

                b.HasIndex(e => e.UserName)
                    .IsUnique();
            });

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If configured, this will be skipped
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=TestUserManager";
                optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150));
            }
        }
    }
}
