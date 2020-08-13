using HenE.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Werkers
{
    public class Klant : Persoon, ICanAnswer, ICanAsk
    {
        public string Answer(string question)
        {
            if (question == "Wat wilt u eten?")
            {
                return "Pizza";
            }

            return string.Empty;
        }

        public string Ask(string question, ICanAnswer wieAntwoord)
        {
            return wieAntwoord.Answer(question);
        }
    }
}
