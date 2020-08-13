namespace Interface
{
    /// <summary>
    /// Vraag de klanten en de medewerker geet antwoord.
    /// </summary>
     public interface IDoeWerk
    {
        /// <summary>
        /// De klant geef aan de medewerker wat hij wil.
        /// </summary>
        /// <param name="vraag"></param>
        /// <returns></returns>
        string WatKlantenHebbenNodig(string vraag);
    }
}
