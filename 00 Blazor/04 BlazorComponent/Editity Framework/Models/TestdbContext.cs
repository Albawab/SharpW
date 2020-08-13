using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Editity_Framework.Models
{
    class TestdbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = @"DESKTOP-BJEHA69",
                InitialCatalog = "Test",
                IntegratedSecurity = true,
            };
            optionsBuilder.UseSqlServer(connectionStringBuilder.ToString());
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>().HasKey(H => new { H.id, H.idRk });
        }
    }
}