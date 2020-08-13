using System;
using System.ComponentModel.DataAnnotations;



namespace HenE_Ej2.blazor_syncfusion.Data
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee ID is required")]
        [RegularExpression("^[0-9]$")]
        public string ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[a-zA-Z'\s]*$", ErrorMessage = "Please enter valid name.")]
        [StringLength(30, MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Second name is required")]
        [RegularExpression(@"^[a-zA-Z'\s]*$")]
        [StringLength(30, MinimumLength = 1)]
        public string SecondName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "Employee ID is required")]
        [RegularExpression("\\d{11}", ErrorMessage = "Please enter valid BSN number.")]
        public string BSN { get; set; }

        [Required(ErrorMessage = "Employee ID is required")]
        [RegularExpression(@"^[a-zA-Z]{2}\s?[0-9]{2}\s?[a-zA-Z]{4}\s?[0-9]{10}$", ErrorMessage = "Please enter valid BSN number.")]
        public string IBAN { get; set; }

        [Required(ErrorMessage = "ZipCode is required")]
        [RegularExpression(@"^[0-9]{4}\s?[a-zA-Z]{2}$", ErrorMessage = "Zip Code is required and must be properly formatted.")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Home number is required")]
        [Range(1, 9999, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int HomeNumber { get; set; }


        [Required(ErrorMessage = "Wachtwoord  is required")]
        [Wachtwoord(Complexititeit = ComplexiteitLevel.low, ErrorMessage = ".")]
        public string Wachtwoord { get; set; }
    }
}
