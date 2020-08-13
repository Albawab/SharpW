using HenE.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HenE.Werkers
{
    public class EnglishTranslator : ITranslate
    {
        public string TranslateToDutch(string englishInput)
        {
            if (englishInput == "hello")
                return "Hallo";

            return string.Empty;
        }
    }
}
