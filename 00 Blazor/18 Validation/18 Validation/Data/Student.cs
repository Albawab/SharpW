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
        [EmailAddress(ErrorMessage ="Email")]
        public string Email { get; set; }

        public string Adres { get; set; }
    }
}
