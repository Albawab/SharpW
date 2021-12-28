using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Tenant
    {
        public Tenant()
        {
            AspNetRoles = new HashSet<AspNetRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }

        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
