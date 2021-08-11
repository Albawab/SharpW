using Identity_UserManager_Auhtentication.Domein.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_UserManager_Auhtentication.Domein
{
    public class GebruikerUser : IdentityUser<Guid>, IAmIdentifiableEntity<Guid>
    {
        public GebruikerUser(
            string id,
            string email,
            string passwordHash,
            string userName
            )
        {           
            this.Id = Guid.Parse(id);
            this.Email = email;
            this.PasswordHash = passwordHash;
            this.UserName = userName;

        }

            [Required]
            [PersonalData]
            public override Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(256)]
        [ProtectedPersonalData]
        public override string UserName { get; set; }


        [Required(AllowEmptyStrings = false)]
        public override string PasswordHash { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(256)]
        [ProtectedPersonalData]
        public override string Email { get; set; }
    
    }
}
