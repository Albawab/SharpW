
namespace Werkers
{
    using HenE.Interface;
    using HenE.Werkers;
    using Interface;

    /// <summary>
    /// De medewerker doet werk.
    /// </summary>
    public class Ober : Persoon,  IDoeWerk, ICanAsk
    {
        public Ober(ITranslate translator)
        {
            this.Translator = translator;
        }

        public ITranslate Translator { get; set; }

        public string Ask(string question, ICanAnswer wieAntwoord)
        {
            return wieAntwoord.Answer(Translator.TranslateToDutch(question));
        }

        public string VraagWatDeKlantWiltEten(Klant klant)
        {
            return Ask("Wat wilt u eten?", klant);
        }

        /// <summary>
        /// Hier gaat de medewerker iets doen.
        /// </summary>
        /// <param name="vraag">Vraag om iets te doen.</param>
        /// <returns>De werk.</returns>
        public string WatKlantenHebbenNodig(string vraag)
        {
            return "Jouw rekening is 50 euro.";
        }
    }
}
