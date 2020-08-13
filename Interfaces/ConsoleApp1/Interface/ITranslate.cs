using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Interface
{
    public interface ITranslate
    {
        /// <summary>
        /// vertaal van de ene taal naar de andere taal
        /// </summary>
        /// <param name="fromCulture">In welke taal is de input</param>
        /// <param name="ToCulture">In welke taal moet de output zijn </param>
        /// <param name="input">Welk woord of zin moet vertaald worden</param>
        /// <returns>De vertaalde input in de toCulture taal</returns>

        string Translate(string fromCulture, string ToCulture, string input);
    }
}



// Generics