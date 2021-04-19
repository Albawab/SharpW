using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _27_Auto_mappen.Data
{
    public class AuthorModel
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Address {get; set;}
        public AddressFullDto AddressObject {get; set;}
        public List<AddressPersist> AddressPersists { get; set; }
    }
}

