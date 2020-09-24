using System.ComponentModel.DataAnnotations;

using static _21_Password_Policy_Configure_ASPNET_Core_Identity.Data.WachtwoordAttribute;

namespace _21_Password_Policy_Configure_ASPNET_Core_Identity.Data
{
    public class Student
    {
        public int Id{ get; set; }
        public string Name{ get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Wachtwoord(Complexititeit = ComplexiteitLevel.High, ErrorMessage = "Wachtwoord is niet geldig.")]
        public string Wachtwoord { get; set; }
    }
}
