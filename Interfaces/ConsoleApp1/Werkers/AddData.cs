namespace Werkers
{
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Add de data to the interface.
    /// </summary>
    public class AddData
    {
        /// <summary>
        /// Add de nieuwe data to the interface.
        /// </summary>
        /// <param name="doeEtens">De werkers.</param>
        /// <returns>Een werker.</returns>
        public List<IDoeEten> VoegDataIn()
        {
            List<IDoeEten> doeEtens = new List<IDoeEten>
            {
                new Moeder() { Age = 33, Naam = "Lieke" },
                new Moeder() { Age = 54, Naam = "Carla" },
                new Vader() { },
                new Chef() { }
            };
            return doeEtens;
        }
    }
}
