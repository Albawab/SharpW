namespace Identity_UserManager_Auhtentication
{
    internal static class Applicatie
    {
        internal const string ApplicatieId = "C8AE1650-01D1-4543-A919-F95BB6CD0DC1";
        internal const string Naam = "Aeolus Beveiliging Service";
        internal const string Omschrijving = "Aeolus Beveiliging Service: De IdP (IdentityProvider; IdentityServer 4) voor alle Aeolus projecten.";

        internal static class Meldingen
        {
            public const string Opstarten = "De {Applicatie} wordt gestart. ({Folder})";
            public const string OnverwachtGestopt = "De {Applicatie} is onverwacht gestopt!";
        }

        internal static class Seq
        {
            public const string EnvironmentVariable = "SEQ_URL";
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Dit is de url die gebruikt wordt als er niets geconfigureerd is en is simpelweg de lokale default url van Seq.")]
            internal static readonly string DefaultUrl = "http://localhost:5341";
        }
    }
}