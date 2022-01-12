// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Linq;
using DataLayer.EfClasses;
using DataLayer.EfCode.Configurations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataLayer.EfCode
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(                             
            DbContextOptions<EfCoreContext> options)      
            : base(options) {}

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void
            OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());       
            modelBuilder.ApplyConfiguration(new BookAuthorConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new LineItemConfig());   
        }

        public override int SaveChanges()
        {
            var changedEntities = ChangeTracker
           .Entries()
           .Where(_ => _.State == EntityState.Added ||
                       _.State == EntityState.Modified);

            var errors = new List<ValidationResult>(); // all errors are here
            foreach (var e in changedEntities)
            {
                var vc = new ValidationContext(e.Entity, null, null);
                Validator.TryValidateObject(
                    e.Entity, vc, errors, validateAllProperties: true);
            }

            return base.SaveChanges();
        }
    }
}

