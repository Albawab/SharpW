namespace Werkers
{
    using Interface;
    using System;

    /// <summary>
    /// Hier gaat de chef koken.
    /// </summary>
    public class Chef : IDoeEten , IDoeWerk
    {

        /// <summary>
        /// De naam.
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Wat de chef kookt.
        /// </summary>
        public string Koken()
        {
            Console.WriteLine("Ik ben de chef.");
            return "pizza";
        }

        /// <summary>
        /// Vraag om te weten dat, Wat de medewerker moet doen.
        /// </summary>
        /// <param name="vraag">De klanten vraagen</param>
        /// <returns>De medewerker geef eten.</returns>
        public string WatKlantenHebbenNodig(string vraag)
        {
            return "Ik heb " + vraag + " Voor u gedaan.";
        }
    }
}
