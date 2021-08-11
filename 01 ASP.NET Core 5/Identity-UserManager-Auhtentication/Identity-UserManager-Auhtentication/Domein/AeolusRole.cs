using Identity_UserManager_Auhtentication.Domein.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_UserManager_Auhtentication.Domein
{
    public class AeolusRole : IdentityRole<Guid>, IAmIdentifiableEntity<Guid>
    {

        [Required]
        public override Guid Id { get; set; }
    }
}
