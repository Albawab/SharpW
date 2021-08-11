using Identity_UserManager_Auhtentication.Domein.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_UserManager_Auhtentication.Model
{
    public class GebruikerUserModel : IdentityUser<Guid>
    {
        public string Color { get; set; }
    }
}
