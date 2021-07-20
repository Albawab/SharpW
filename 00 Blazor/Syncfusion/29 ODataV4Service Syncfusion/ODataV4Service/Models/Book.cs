using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ODataV4Service.Models
{ 

    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Ingresa un correo electrónico válido")]
        [Required(ErrorMessage = "Ingresa el correo del empleado")]
        [RegularExpression(".*(@prosa.com.mx|@carnet.com.mx|@asesoresdesoluciones.mx|@glints.com.mx)$", ErrorMessage = "El correo electrónico no pertenece a Prosa")]
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int CreditLimit { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }        
    }
    public enum Gender
    {        
        [Display(Name = "Male")]
        Male,
        
        [Display(Name = "Female")]
        Female,
        
    }
}
