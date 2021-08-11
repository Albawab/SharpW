using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityBase.Model
{
    class Car : IdentityUser<Guid>
    {
        public string Color{ get; set; }
    }
}
