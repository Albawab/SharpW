using System.ComponentModel.DataAnnotations;


namespace _18_Validation.Data
{
    public class Student
    {
        [Required]
        public string Id { get; set; }


        [Required]
        public string Naam { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email")]
        public string Email { get; set; }

        public string Adres { get; set; }
        /// <summary>
        /// Gets huis nummer van een medewerker.
        /// </summary>
        [Required(ErrorMessage = "Huisnummer is verplicht")]
        [RegularExpression("^[0-9]$")]
        [Range(1, 999, ErrorMessage = "De huisnummer moet tussen {1} en {2} zijn.")]
        public int HuisNummer { get; private set; }

        [Required(ErrorMessage = "Wachtwoord  is required")]
        [Wachtwoord(Complexititeit = ComplexiteitLevel.low, ErrorMessage = ".")]
        public string Wachtwoord { get; set; }
    }
}
