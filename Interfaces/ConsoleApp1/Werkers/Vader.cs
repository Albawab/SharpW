namespace Werkers
{
    using Interface;
    using System;

    /// <summary>
    /// Hier gaat de vader koken.
    /// </summary>
    public class Vader : IDoeEten
    {

        /// <summary>
        /// De naam.
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// Wat de vader kookt.
        /// </summary>
        /// <returns>Sort eten</returns>
        public string Koken()
        {
            Console.WriteLine("Ik ben de vader.");
            return "rijst";
        }
    }
}
