﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27_Auto_mappen.Data
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string ToInt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<AddressFullDto> AddressObjects { get; set; }

        public DifferentNameFull DifferentNameFull { get; set; }

        public ICollection<Emails> Emails { get; set; }
    }
}
