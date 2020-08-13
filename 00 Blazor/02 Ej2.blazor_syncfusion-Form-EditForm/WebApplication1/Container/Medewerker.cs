namespace HenE_Application.Container
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Hier in staat de gegevens van de medewerkers.
    /// </summary>
    public class Medewerker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Medewerker"/> class.
        /// </summary>
        /// <param name="id">De id van een medewerker.</param>
        public Medewerker(int id) => this.Id = id;

        /// <summary>
        /// Gets of sets de id van een medewerker.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets de voornaam van een medewerker.
        /// </summary>
        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string VoorNaam { get; private set; }

        /// <summary>
        /// Gets Achter naam van een medewerker.
        /// </summary>
        [Required(ErrorMessage = "Achter is verplicht")]
        public string AchterNaam { get; private set; }

        /// <summary>
        /// Gets Email van een medewerker.
        /// </summary>
        [Required(ErrorMessage = "Email is verplicht")]
        public string Email { get; private set; }

        /// <summary>
        /// Gets huis nummer van een medewerker.
        /// </summary>
        [Required(ErrorMessage = "Huisnummer is verplicht")]
        [RegularExpression("^[0-9]$")]
        [Range(1, 999, ErrorMessage = "De huisnummer moet tussen {1} en {2} zijn.")]
        public int HuisNummer { get; private set; }
    }
}
