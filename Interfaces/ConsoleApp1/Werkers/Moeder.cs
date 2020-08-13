namespace Werkers
{
    using System;
    using Interface;

    /// <summary>
    /// Hier gaat de moeder koken.
    /// </summary>
    public class Moeder : IDoeEten
    {
        /// <summary>
        /// Age van de moeder.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// De naam van de moeder.
        /// </summary>
        public string Naam { get; set; }
        /// <summary>
        /// Wat de moeder kookt.
        /// </summary>
        public string Koken()
        {
            Console.WriteLine("Ik ben de moeder.");
            return "aardappel met vlees";
        }
    }
}
