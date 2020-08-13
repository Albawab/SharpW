// <copyright file="KennisgevingDouane.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// De kennisgeving douane formulier.
    /// </summary>
    public class KennisgevingDouane : Formulier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KennisgevingDouane"/> class.
        /// </summary>
        public KennisgevingDouane()
            : base("Kennisgeving Douane")
        {
            List<FormulierElement> elements = new List<FormulierElement>();
            elements.Add(this.AddBedrijfsgegevens());
            elements.Add(this.AddGegevensVergunning());
            elements.Add(this.AddGegevensKennisgeving());
            elements.Add(this.AddGegevensAangifteOfBewijsstuk());
            elements.Add(this.AddRuimteVoorToelichting());
            elements.Add(this.AddOndertekening());
            elements.Add(this.AddSectionsInsideOteherMainSection());
            elements.Add(this.AddToast());
            this.Kinderen = elements;
        }

        /// <summary>
        /// Create een nieuwe sectie waar de elementen van het bedrijf staat.
        /// </summary>
        /// <returns>Nieuwe sectie.</returns>
        private FormulierElement AddBedrijfsgegevens()
        {
            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierVraag() { Row = 1, Rows = 1, Column = 1, Columns = 2, Text = "Naam", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 2, Rows = 2, Column = 1, Columns = 2, Text = "Adres", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 3, Rows = 2, Column = 1, Columns = 2, Text = "Postcode ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 3, Rows = 2, Column = 0, Columns = 1, Text = "Plaats", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 4, Rows = 2, Column = 1, Columns = 2, Text = "Telefoonnummer  ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 4, Rows = 2, Column = 0, Columns = 1, Text = "Faxnummer", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 5, Rows = 2, Column = 1, Columns = 2, Text = "EORI-nummer/ RSIN", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 5, Rows = 0, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierTooltip() { Content = "type hier je naam", ShowTipPointer = true, Position = Enumeration.TooltipPosition.LeftBottom },
            };
            return new FormulierSectie()
            {
                Row = 1,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Uw bedrijfsgegevens",
                SectionNumber = 1,
                SectionKinderen = secties,
            };
        }

        /// <summary>
        /// Create een nieuwe sectie waar de elementen van het bedrijf staat.
        /// </summary>
        /// <returns>Nieuwe element.</returns>
        private FormulierElement AddGegevensVergunning()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 2,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Uw bedrijfsgegevens",
                SectionNumber = 2,
            };

            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag() { Row = 1, Rows = 1, Column = 0, Columns = 2, Text = "Naam vergunning ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag { Row = 2, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag() { Row = 2, Rows = 2, Column = 0, Columns = 2, Text = "Vergunningnummer", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
            };

            formulierSectie.SectionKinderen = secties;
            return formulierSectie;
        }

        /// <summary>
        /// Create een nieuwe sectie waar de elementen van het bedrijf staat.
        /// </summary>
        /// <returns>Nieuwe element.</returns>
        private FormulierElement AddGegevensKennisgeving()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 3,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Gegevens kennisgeving",
                SectionNumber = 3,
            };

            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag()
                {
                    Row = 1, Rows = 1, Column = 0, Columns = 2, Text = "Soort kennisgeving", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Aankomst/inslag" },
                    new FormulierAntwoord() { Row = 1, Rows = 1, Column = 1, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Vertrek/uitslag" },
                    new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Onregelmatigheden" },
                    new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = " Breuk " },
                    new FormulierAntwoord() { Row = 1, Rows = 1, Column = 1, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Bewerkingen" },
                },
                },
                new FormulierVraag { Row = 2, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag() { Row = 2, Rows = 1, Column = 0, Columns = 2, Text = "Nummer van de kennisgeving", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 1, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag { Row = 2, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
                new FormulierVraag() { Row = 2, Rows = 0, Column = 0, Columns = 1, Text = "Datum ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Date } } },

                new FormulierVraag { Row = 3, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "d" },
                new FormulierVraag() { Row = 3, Rows = 0, Column = 0, Columns = 2, Text = "Plaats van de kennisgeving", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 1, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag { Row = 3, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "e" },
                new FormulierVraag() { Row = 3, Rows = 1, Column = 0, Columns = 1, Text = " Tijdstip", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Tijd } } },
                new FormulierVraag { Row = 4, Column = 0, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "f" },
                new FormulierVraag() { Row = 4, Rows = 1, Column = 0, Columns = 2, Text = "Kenteken of containernr(s)", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 1, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
            };

            formulierSectie.SectionKinderen = secties;
            return formulierSectie;
        }

        /// <summary>
        /// Create een nieuwe sectie waar de elementen van het bedrijf staat.
        /// </summary>
        /// <returns>Nieuwe element.</returns>
        private FormulierElement AddGegevensAangifteOfBewijsstuk()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 4,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Gegevens kennisgeving",
                SectionNumber = 4,
            };

            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "Nr." },
                new FormulierVraag { Row = 1, Column = 0, Columns = 2, Text = "A Aangifte of bewijsstuk" },
                new FormulierVraag { Row = 1, Column = 0, Columns = 2, Text = "B Nummer aangifte of bewijsstuk" },
                new FormulierVraag { Row = 1, Column = 0, Columns = 3, Text = "C Goederenomschrijving en alco-holpercentage of platogehalte" },
                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "D Goederen-code" },
                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "E Aantal colli" },
                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "F Gewicht, liters, stuks" },
                new FormulierVraag
                {
                    Row = 2, Column = 0, Columns = 1, Text = "01", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 2, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 2, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 2, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 2, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 2, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                },
                },
                new FormulierVraag
                {
                    Row = 3, Column = 0, Columns = 1, Text = "02", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 3, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 3, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 3, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 3, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 3, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 3, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                },
                },
                new FormulierVraag
                {
                    Row = 4, Column = 0, Columns = 1, Text = "03", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 4, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 4, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 4, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 4, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 4, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 4, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                },
                },
                new FormulierVraag
                {
                    Row = 5, Column = 0, Columns = 1, Text = "04", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 5, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 5, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 5, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 5, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 5, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 5, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                },
                },

                new FormulierVraag { Row = 6, Column = 0, Columns = 1, Text = "Nr." },
                new FormulierVraag { Row = 6, Column = 0, Columns = 2, Text = "G Herkomst, bestemming" },
                new FormulierVraag { Row = 6, Column = 3, Columns = 1, Text = "H Valuta" },
                new FormulierVraag { Row = 6, Column = 0, Columns = 2, Text = "I Waarde" },
                new FormulierVraag { Row = 6, Column = 0, Columns = 3, Text = "J Verzegeling" },

                new FormulierVraag
                {
                    Row = 7, Column = 0, Columns = 1, Text = "01", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 7, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 7, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 7, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 7, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Ja" },
                    new FormulierAntwoord { Row = 7, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Nee" },
                },
                },
                new FormulierVraag
                {
                    Row = 8, Column = 0, Columns = 1, Text = "02", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 8, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 8, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 8, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 8, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Ja" },
                    new FormulierAntwoord { Row = 8, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Nee" },
                },
                },
                new FormulierVraag
                {
                    Row = 9, Column = 0, Columns = 1, Text = "03", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 9, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 9, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 9, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 9, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Ja" },
                    new FormulierAntwoord { Row = 9, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Nee" },
                },
                },
                new FormulierVraag
                {
                    Row = 10, Column = 0, Columns = 1, Text = "04", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 10, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 10, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 10, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text, },
                    new FormulierAntwoord { Row = 10, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Ja" },
                    new FormulierAntwoord { Row = 10, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.RadioButton, AntwoordToelichting = "Nee" },
                },
                },
            };

            formulierSectie.SectionKinderen = secties;
            return formulierSectie;
        }

        /// <summary>
        /// Create een nieuwe sectie waar de elementen van het bedrijf staat.
        /// </summary>
        /// <returns>Nieuwe element.</returns>
        private FormulierElement AddRuimteVoorToelichting()
        {
            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierVraag() { Row = 1, Rows = 1, Column = 1, Columns = 10, Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 1, Rows = 1, Column = 1, Columns = 10, SoortAntwoord = SoortAntwoord.Textarea } } },
            };
            return new FormulierSectie()
            {
                Row = 5,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Ruimte voor toelichting",
                SectionNumber = 5,
                SectionKinderen = secties,
            };
        }

        /// <summary>
        /// Create een nieuwe sectie waar de elementen van het bedrijf staat.
        /// </summary>
        /// <returns>Nieuwe sectie.</returns>
        private FormulierElement AddOndertekening()
        {
            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierVraag() { Row = 1, Rows = 1, Column = 1, Columns = 2, Text = "Naam", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 2, Rows = 2, Column = 1, Columns = 2, Text = "Functie", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 3, Rows = 2, Column = 1, Columns = 2, Text = "Plaats", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                new FormulierVraag() { Row = 4, Rows = 2, Column = 1, Columns = 2, Text = "Datum", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Date } } },
                new FormulierVraag() { Row = 5, Rows = 2, Column = 1, Columns = 2, Text = "Extra bijlagen (aantal)", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 5, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
            };
            return new FormulierSectie()
            {
                Row = 6,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Ondertekening",
                SectionNumber = 6,
                SectionKinderen = secties,
            };
        }

        /// <summary>
        /// Add een toast seaction aan het formulier.
        /// </summary>
        /// <returns>Een nieuwe section.</returns>
        private FormulierElement AddToast()
        {
            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierToast() { Row = 20, XPosition = Enumeration.HorizontalAlign.Right, YPosition = Enumeration.VerticalAlign.Top, Title = "Success", Content = "Prima!" },
            };

            return new FormulierSectie()
            {
                Row = -1,
                SectionKinderen = secties,
            };
        }

        /// <summary>
        /// Voeg een secties binnen en andere hoofd sectie.
        /// </summary>
        /// <returns>Een nieuwe sectie.</returns>
        private FormulierElement AddSectionsInsideOteherMainSection()
        {
            List<FormulierElement> secties = new List<FormulierElement>()
            {
                new FormulierSectie
                {
                Row = 1,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Sectie1",
                SectionNumber = 88,
                SectionKinderen = new List<FormulierElement>
                {
                    new FormulierVraag() { Row = 1, Rows = 1, Column = 1, Columns = 2, Text = "Naam", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 2, Rows = 2, Column = 1, Columns = 2, Text = "Adres", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 3, Rows = 2, Column = 1, Columns = 2, Text = "Postcode ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 3, Rows = 2, Column = 0, Columns = 1, Text = "Plaats", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 4, Rows = 2, Column = 1, Columns = 2, Text = "Telefoonnummer  ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 4, Rows = 2, Column = 0, Columns = 1, Text = "Faxnummer", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 5, Rows = 2, Column = 1, Columns = 2, Text = "EORI-nummer/ RSIN", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 5, Rows = 0, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                },
                },
                new FormulierSectie
                {
                 Row = 2,
                 Rows = 0,
                 Column = 0,
                 Columns = 12,
                 Title = "Sectie2",
                 SectionNumber = 98,
                 SectionKinderen = new List<FormulierElement>
                {
                    new FormulierVraag() { Row = 1, Rows = 1, Column = 1, Columns = 2, Text = "Naam", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 2, Rows = 2, Column = 1, Columns = 2, Text = "Adres", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 3, Rows = 2, Column = 1, Columns = 2, Text = "Postcode ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 3, Rows = 2, Column = 0, Columns = 1, Text = "Plaats", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 4, Rows = 2, Column = 1, Columns = 2, Text = "Telefoonnummer  ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 4, Rows = 2, Column = 0, Columns = 1, Text = "Faxnummer", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 5, Rows = 2, Column = 1, Columns = 2, Text = "EORI-nummer/ RSIN", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 5, Rows = 0, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                },
                },
                new FormulierSectie
                {
                Row = 3,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Sectie3",
                SectionNumber = 108,
                SectionKinderen = new List<FormulierElement>
                {
                    new FormulierVraag() { Row = 1, Rows = 1, Column = 1, Columns = 2, Text = "Naam", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 1, Rows = 1, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 2, Rows = 2, Column = 1, Columns = 2, Text = "Adres", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 2, Rows = 2, Column = 0, Columns = 8, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 3, Rows = 2, Column = 1, Columns = 2, Text = "Postcode ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 3, Rows = 2, Column = 0, Columns = 1, Text = "Plaats", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 3, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 4, Rows = 2, Column = 1, Columns = 2, Text = "Telefoonnummer  ", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 4, Rows = 2, Column = 0, Columns = 1, Text = "Faxnummer", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 4, Rows = 2, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.Text } } },
                    new FormulierVraag() { Row = 5, Rows = 2, Column = 1, Columns = 2, Text = "EORI-nummer/ RSIN", Antwoorden = new List<FormulierAntwoord>() { new FormulierAntwoord() { Row = 5, Rows = 0, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text } } },
                },
                },
            };

            return new FormulierSectie()
            {
                Row = 7,
                Rows = 0,
                Column = 0,
                Columns = 12,
                Title = "Secties",
                SectionNumber = 7,
                SectionKinderen = secties,
            };
        }
    }
}
