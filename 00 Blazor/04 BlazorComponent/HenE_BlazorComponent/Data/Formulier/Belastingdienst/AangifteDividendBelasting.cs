// <copyright file="AangifteDividendBelasting.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_BlazorComponent.Data
{
    using System.Collections.Generic;
    using HenE_BlazorComponent.Enumeration;

    /// <summary>
    /// De aangift dividen belasting.
    /// </summary>
    public class AangifteDividendBelasting : Formulier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AangifteDividendBelasting"/> class.
        /// </summary>
        public AangifteDividendBelasting()
            : base("Aangifte dividendbelasting")
        {
            List<FormulierElement> formulierElements = new List<FormulierElement>();
            formulierElements.Add(this.CreateUitkeringenGeenDividendbelastingIngoudenSection());
            formulierElements.Add(this.CreateUitkeringenMetvijftienprocentSection());
            formulierElements.Add(this.CreateUitkeringenVolgensBRKSection());
            formulierElements.Add(this.CreateDividendbelastingBijzondereSituatiesSection());
            formulierElements.Add(this.AfdrachtverminderingenSection());
            formulierElements.Add(this.VerzamelstaatSection());
            formulierElements.Add(this.CreateKinderenSection());
            formulierElements.Add(this.CreateKinderenSectionMedium());
            formulierElements.Add(this.CreateKinderenSectionBig());
            formulierElements.Add(this.CreateGegevensSection());
            formulierElements.Add(this.CreateAandelenSection());
            formulierElements.Add(this.CreateUitkeringenSection());
            formulierElements.Add(this.AanvullendeinformatieSection());
            formulierElements.Add(this.CreateOndertekeningSection());
            this.Kinderen = formulierElements;
        }

        /// <summary>
        /// Create een nieuwe section element.
        /// </summary>
        /// <returns>Nieuwe element.</returns>
        private FormulierElement CreateKinderenSection()
        {
            List<FormulierElement> formulierElementen = new List<FormulierElement>()
            {
                new FormulierSpecificatie
                {
                    Row = 1, Columns = 12, Column = 1, SpecificatieSize = SpecificatieSize.Small, SpecificatieSoort = SpecificatieSoort.Normaal,
                    Elements = new List<FormulierElement>
                                            {
                                                new FormulierVraag { Row = 1, Column = 2, Columns = 1, Text = "Naam", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "Voorletter", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "AchterNaam", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "Geboortedatum", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Date }, }, },
                                            },
                },
            };

            // voeg de elementen to
            return new FormulierSectie()
            {
                Row = 1,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 0,
                Title = "Kinderbijslag Klein",
                SectionKinderen = formulierElementen,
            };
        }

        /// <summary>
        /// Create een nieuwe section element.
        /// </summary>
        /// <returns>Nieuwe element.</returns>
        private FormulierElement CreateKinderenSectionMedium()
        {
            List<FormulierElement> formulierElementen = new List<FormulierElement>()
            {
                new FormulierSpecificatie
                {
                    Row = 1, Columns = 12, Column = 1, SpecificatieSize = SpecificatieSize.Medium, SpecificatieSoort = SpecificatieSoort.InlineEditing,
                    Elements = new List<FormulierElement>
                                            {
                                                new FormulierVraag { Row = 1, Column = 2, Columns = 1, Text = "Naam", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "Voorletter", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "AchterNaam", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "Geboortedatum", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Date }, }, },
                                            },
                    Kinder = new KinderFormulier(),
                },
            };

            // voeg de elementen to
            return new FormulierSectie()
            {
                Row = 2,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 1,
                Title = "Kinderbijslag Inline",
                SectionKinderen = formulierElementen,
            };
        }

        /// <summary>
        /// Create een nieuwe section element.
        /// </summary>
        /// <returns>Nieuwe element.</returns>
        private FormulierElement CreateKinderenSectionBig()
        {
            List<FormulierElement> formulierElementen = new List<FormulierElement>()
            {
                new FormulierSpecificatie
                {
                    Row = 1, Columns = 12, Column = 1, SpecificatieSize = SpecificatieSize.Big, SpecificatieSoort = SpecificatieSoort.Normaal,
                    Elements = new List<FormulierElement>
                                            {
                                                new FormulierVraag { Row = 1, Column = 2, Columns = 1, Text = "Naam", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "Voorletter", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "AchterNaam", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Text }, }, },
                                                new FormulierVraag { Row = 1, Column = 0, Columns = 1, Text = "Geboortedatum", Antwoorden = new List<FormulierAntwoord> { new FormulierAntwoord { Row = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Date }, }, },
                                            },
                },
            };

            // voeg de elementen to
            return new FormulierSectie()
            {
                Row = 3,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 2,
                Title = "Kinderbijslag Groot",
                SectionKinderen = formulierElementen,
            };
        }

        /// <summary>
        ///  Create een nieuwe section Element.
        /// </summary>
        /// <returns>Niuwe element.</returns>
        private FormulierElement CreateGegevensSection()
        {
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 2, Columns = 2, Text = "Naam vennootschap" },
                new FormulierVraag { Row = 3, Column = 2, Columns = 2, Text = "Adres" },
                new FormulierVraag { Row = 4, Column = 2, Columns = 2, Text = "Postcode en plaats" },
                new FormulierVraag { Row = 5, Column = 2, Columns = 2, Text = "Uw aangiftenummer" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 7, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 7, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.Text },
                new FormulierAntwoord { Row = 5, Column = 0, Columns = 7, SoortAntwoord = SoortAntwoord.Text },
                new FormulierToelichting { Row = 6, Column = 2, Columns = 2, ToelichtingText = "Vult u de aangifte niet in op de computer? Stel dan hiernaast zelf uw aanfigtenummer samen." },
                new FormulierToelichting { Row = 6, Column = 0, Columns = 7, ToelichtingText = "Vakje 01 t/m 09: Vul uw RSIN/fiscaal nummer in. Als uw nummer minder dan 9 cijfers heeft, dan vooraan aanmullen met nullen." },
                new FormulierToelichting { Row = 7, Column = 4, Columns = 7, ToelichtingText = "U hebt uw aangiftenummer ook nodig als u het bedrag van deze aangifte betaalt." },
            };

            // voeg de elementen to
            return new FormulierSectie()
            {
                Row = 5,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 3,
                Title = "Gegevens vennootschap",
                SectionKinderen = formulierVraagen,
            };
        }

        /// <summary>
        /// Create new section waar de gegeven van de aandelen staan.
        /// </summary>
        /// <returns>Aandelen Section.</returns>
        private FormulierElement CreateAandelenSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 6,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 4,
                Title = "Aandelen",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag { Row = 2, Column = 0, Columns = 2, Text = "Gestort aandelenkapitaal" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 7, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierToelichting { Row = 6, Column = 2, Columns = 8, ToelichtingText = "Let Op! Kwalificerende lidmaatschapsrechten van een cooperatie worden in de dividendbelasting gelijkgesteld met aandelen. Deze geven recht op ten minste 5% van de winst of een eventuele liquidatie-uitkering." },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create een nieuwe section element waar de gegeven van de uitkeringen staan.
        /// </summary>
        /// <returns>Uitkeringen section.</returns>
        private FormulierSectie CreateUitkeringenSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 7,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 5,
                Title = "Uitkeringen",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 1, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag { Row = 1, Column = 0, Columns = 2, Text = "Op welke datum heeft uw vennootschap dividend beschikbaar gesteld?" },
                new FormulierAntwoord { Row = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Date },
                new FormulierToelichting { Row = 1, Column = 2, Columns = 4, ToelichtingText = "Let op! Het gaat om de dag waarop het dividend besckikbaar is gesteld en niet om de dag waarop het dividend is uitbetaald." },

                new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag { Row = 2, Column = 0, Columns = 2, Text = "Over welk boekjaar heeft uw vennootschap dividend beschikbaar gesteld?" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Date },

                new FormulierVraag { Row = 3, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
                new FormulierVraag { Row = 3, Column = 0, Columns = 2, Text = "Waaruit wordt het dividend uitgekeerd?" },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uit de winst (reserves). wordt het dividend alleen uit de wins uitgekeerd?\n Ga dan verder met vraag 3a." },
                new FormulierAntwoord { Row = 3, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 3, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uit de agioreserve." },
                new FormulierAntwoord { Row = 3, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierToelichting { Row = 4, Column = 2, Columns = 5, ToelichtingText = "Let op!Het omrekenen van nettobedragen naar brutobedragen (bruteren) is verplicht als de vennootschap de dividendbelasting voor eigen rekening neemt." },
                new FormulierVraag { Row = 5, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "d" },
                new FormulierVraag { Row = 5, Column = 0, Columns = 2, Text = "Totaalbedrag uitkering" },
                new FormulierAntwoord { Row = 5, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 6, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "e" },
                new FormulierVraag { Row = 6, Column = 0, Columns = 2, Text = "Waaruit bestond de uitkering uit de agioreserve? Kruis aan en vermeld het bedrag." },
                new FormulierAntwoord { Row = 6, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Bonusaandelen ter waarde van" },
                new FormulierAntwoord { Row = 6, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 7, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Geld" },
                new FormulierAntwoord { Row = 7, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 8, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "f" },
                new FormulierToelichting { Row = 8, Column = 0, Columns = 4, ToelichtingText = "Hoe groot is de agioreserve na de uitkering?" },
                new FormulierAntwoord { Row = 8, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 9, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "g" },
                new FormulierToelichting { Row = 9, Column = 0, Columns = 4, ToelichtingText = "Overige vergoedingen voor kapitaalverstrekking door houdstercoöperaties" },
                new FormulierAntwoord { Row = 9, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create Uitkeringen waarop geen dividendbelasting wordt ingehouden section.
        /// </summary>
        /// <returns>Uitkeringen waarop geen dividendbelasting wordt ingehouden Section.</returns>
        private FormulierSectie CreateUitkeringenGeenDividendbelastingIngoudenSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 8,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 6,
                Title = "Uitkeringen waarop geen dividendbelasting wordt ingehouden",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag { Row = 2, Column = 0, Columns = 2, Text = "Keert de vennootschap dividend uit waarop geen dividendbelasting hoeft te worden ingehouden?" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Nee. Ga verder met vraag 4." },
                new FormulierAntwoord { Row = 3, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Ja" },

                new FormulierVraag { Row = 4, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag { Row = 4, Column = 0, Columns = 2, Text = "Hoeveel is de uitkering?" },
                new FormulierAntwoord { Row = 4, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 5, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
                new FormulierVraag { Row = 5, Column = 0, Columns = 2, Text = "Waarom hoeft de vennootschap geen dividendbelasting in te houden?" },
                new FormulierAntwoord { Row = 5, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Er is sprake van de deelnemingsvrijstelling (artikel 4, lid 1, onderdeel a)" },
                new FormulierAntwoord { Row = 6, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Er is sprake van een fiscale eenheid (artikel 4, lid 1, onderdeel b)." },
                new FormulierAntwoord { Row = 7, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "De vennootschap is een aangewezen bank- of beleggingsinstelling (artikel 4, lid 5)." },
                new FormulierAntwoord { Row = 8, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Het gaat om uitkeringen door beleggingsinstellingen voor lijfrente- of stamrechtbeleggingsrechten (artikel 4, lid 6)." },
                new FormulierAntwoord { Row = 9, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Het gaat om een vrijgestelde inkoop van aandelen (artikel 4c)." },
                new FormulierAntwoord { Row = 10, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Het gaat om inkoop van eigen aandelen door een beleggingsinstelling (artikel 4d)." },
                new FormulierAntwoord { Row = 11, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Het gaat om een vererfd aanmerkelijk belang (artikel 4e)." },
                new FormulierAntwoord { Row = 12, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Het gaat om een indirecte overdracht van aandelen of winstbewijzen die bij een aanmerkelijk belang horen (artikel 4f)." },
                new FormulierToelichting { Row = 13, Column = 2, Columns = 9, ToelichtingText = "Vermeld de volgende gegevens bij vraag 9 ‘Aanvullende informatie’ of op een bijlage:\n– bij de deelnemingsvrijstelling of een fiscale eenheid: voor iedere ontvanger naam, adres en bedrag van de uitkering \n– bij een vrijgestelde inkoop van aandelen: de inkoopbedragen(inclusief daarin opgenomen kapitaal) per soort ingekochte aandelen \n– bij inkoop van eigen aandelen door een beleggingsinstelling: de grondslag voor de inhouding" },
                new FormulierToelichting { Row = 14, Column = 2, Columns = 10, ToelichtingText = "Let op! Is de uitkering gedeeltelijk vrijgesteld? Gebruik voor dat deel het opgaafformulier ‘Vrijgestelde uitkeringen aan buitenlandsegerechtigden in deelnemingssituaties’." },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create uitkering met 15% inhouden dividendbelasting.
        /// </summary>
        /// <returns>uitkering met 15% inhouden dividendbelasting Section.</returns>
        private FormulierSectie CreateUitkeringenMetvijftienprocentSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 9,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 7,
                Title = "Uitkeringen met 15% ingehouden dividendbelasting",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag { Row = 2, Column = 0, Columns = 2, Text = "Keert de vennootschap dividend uit waarop 15% dividendbelasting wordt ingehouden?" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Nee. Ga verder met vraag 5." },
                new FormulierAntwoord { Row = 3, Column = 4, Columns = 5, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Ja" },

                new FormulierVraag { Row = 4, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag { Row = 4, Column = 0, Columns = 2, Text = "In welke vorm wordt het dividend uitgekeerd? Kruis aan en vermeld het bedrag." },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uitkering van winst in geld" },
                new FormulierAntwoord { Row = 4, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 7, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uitkering van winst in aandelen of bewijzen van deelgerechtigdheid" },
                new FormulierAntwoord { Row = 7, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 8, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uitkering van winst op een andere wijze" },
                new FormulierAntwoord { Row = 8, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 9, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Afkoop of inkoop van winstbewijzen" },
                new FormulierAntwoord { Row = 9, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 10, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Inkoop van eigen aandelen" },
                new FormulierAntwoord { Row = 10, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 11, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Liquidatie-uitkeringen " },
                new FormulierAntwoord { Row = 11, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 12, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Teruggaaf gestort kapitaal op aandelen of bewijzen van deelgerechtigdheid" },
                new FormulierAntwoord { Row = 12, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 13, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Rente van hybride leningen" },
                new FormulierAntwoord { Row = 13, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 14, Column = 4, Columns = 4, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Rente van winstdelende obligaties" },
                new FormulierAntwoord { Row = 14, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 15, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
                new FormulierVraag { Row = 15, Column = 0, Columns = 2, Text = "Totaalbedrag 15%-uitkeringen" },
                new FormulierAntwoord { Row = 15, Column = 5, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 16, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "d" },
                new FormulierVraag { Row = 16, Column = 0, Columns = 2, Text = "Neemt de vennootschap de dividendbelasting voor eigen rekening?" },
                new FormulierAntwoord { Row = 16, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Nee. Neem 15% van het bedrag bij 4c." },
                new FormulierAntwoord { Row = 17, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Ja. Neem (100/85)-1 van het bedrag bij 4c." },
                new FormulierAntwoord { Row = 16, Column = 3, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierToelichting { Row = 18, Column = 2, Columns = 9, ToelichtingText = "Let op! Vul in bij 8a in de verzamelstaat. Het omrekenen van nettobedragen naar brutobedragen (bruteren) is verplicht als de vennootschap de dividendbelasting voor eigen rekening neemt." },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create Uitkeringen met ingehouden dividendbelasting volgens een verdragspercentage of de BRK Section.
        /// </summary>
        /// <returns>Uitkeringen met ingehouden dividendbelasting volgens een verdragspercentage of de BRK Section.</returns>
        private FormulierSectie CreateUitkeringenVolgensBRKSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 10,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 8,
                Title = "Uitkeringen met ingehouden dividendbelasting volgens een verdragspercentage of de BRK",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag { Row = 2, Column = 0, Columns = 2, Text = "Heeft de vennootschap een IB-92-verklaring (vraag 7 uit het formulier ‘Verzoek om (gedeeltelijke) vrijstelling van Nederlandse dividendbelasting’) van de belastingplichtige of een vergunning om geen of minder dividendbelasting te betalen?" },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Nee. Ga verder met vraag 6" },
                new FormulierAntwoord { Row = 3, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Ja. Vul in: het verdragspercentage dividendbelasting uit het belastingverdrag, BRK of BRNC." },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierToelichting { Row = 3, Column = 0, Columns = 1, ToelichtingText = "," },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierToelichting { Row = 3, Column = 0, Columns = 3, ToelichtingText = "%\nStuur de IB-92-verklaring (het formulier ‘Verzoek om (gedeeltelijke) vrijstelling van Nederlandse dividendbelasting’) of een kopie van devergunningmee." },
                new FormulierToelichting { Row = 4, Column = 2, Columns = 7, ToelichtingText = "Let op! Het percentage is afhankelijk van het land waarmee het verdrag is gesloten. Stuur een berekening mee bij meer dan 1 verdragspercentage." },

                new FormulierVraag { Row = 5, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag { Row = 5, Column = 0, Columns = 2, Text = "In welke vorm wordt het dividend uitgekeerd? Kruis aan en vermeld het bedrag." },
                new FormulierAntwoord { Row = 5, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uitkering van winst in geld" },
                new FormulierAntwoord { Row = 5, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 6, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uitkering van winst in aandelen of bewijzen van deelgerechtigdheid" },
                new FormulierAntwoord { Row = 6, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 7, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Uitkering van winst op een andere wijze" },
                new FormulierAntwoord { Row = 7, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 8, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Afkoop of inkoop van winstbewijzen" },
                new FormulierAntwoord { Row = 8, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 9, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Inkoop van eigen aandelen" },
                new FormulierAntwoord { Row = 9, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 10, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = " Teruggaaf gestort kapitaal op aandelen of bewijzen van deelgerechtigdheid" },
                new FormulierAntwoord { Row = 10, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 11, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Rente van hybride leningen" },
                new FormulierAntwoord { Row = 11, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 12, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Rente van winstdelende obligaties" },
                new FormulierAntwoord { Row = 12, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 13, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
                new FormulierVraag { Row = 13, Column = 0, Columns = 2, Text = "Totaalbedrag uitkeringen volgens verdragspercentage" },
                new FormulierAntwoord { Row = 13, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 14, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "d" },
                new FormulierVraag { Row = 14, Column = 0, Columns = 2, Text = "Neemt de vennootschap de dividendbelasting voor eigen rekening?" },
                new FormulierAntwoord { Row = 14, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Nee. Neem (5a)% van het bedrag bij 5c." },
                new FormulierAntwoord { Row = 15, Column = 4, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Ja. Neem (100/(100-5a)) -1 van het bedrag bij 5c." },
                new FormulierAntwoord { Row = 15, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierToelichting { Row = 17, Column = 2, Columns = 8, ToelichtingText = "Let op! Vul in bij 8b in de verzamelstaat.\n(5a) is het percentage dividendbelasting uit het belastingverdrag of de BRK." },
                new FormulierToelichting { Row = 18, Column = 2, Columns = 8, ToelichtingText = "Let op! Het omrekenen van nettobedragen naar brutobedragen (bruteren) is verplicht als de vennootschap de dividendbelasting voor eigen rekening neemt." },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create dividendbelasting bijzondere situaties section.
        /// </summary>
        /// <returns> nieuwe dividendbelasting bijzondere situaties section.</returns>
        private FormulierSectie CreateDividendbelastingBijzondereSituatiesSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 11,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 9,
                Title = "Dividendbelasting bijzondere situaties",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag { Row = 2, Column = 0, Columns = 7, Text = "Dividendbelasting over inkoop van eigen aandelen door beursgenoteerde vennootschappen. Heeft de vennootschap eigen aandelen ingekocht? En blijkt dat aan het eind van het kalenderjaar dat in dat jaar niet isvoldaan aan devoorwaarden van devrijgestelde inkoop van aandelen volgens artikel 4c? Dan moet u alsnog dividendbelasting betalen." },
/*                new FormulierToelichting { Row = 3, Column = 2, Columns = 1, ToelichtingText = "Bereken: opbrengst" },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierToelichting { Row = 3, Column = 0, Columns = 1, ToelichtingText = "x (100/85) x 15% =" },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 1, SoortAntwoord = SoortAntwoord.Nummer },
                new FormulierAntwoord { Row = 3, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },*/

                new FormulierVraag { Row = 4, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag { Row = 4, Column = 0, Columns = 6, Text = "Niet toepassen vrijstelling dividendbelasting: welk bedrag heeft de vennootschap ingehouden?" },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

                new FormulierVraag { Row = 13, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
/*                new FormulierToelichting { Row = 5, Column = 2, Columns = 5, ToelichtingText = "Dividendbelasting bijzondere situaties" },
                new FormulierAntwoord { Row = 5, Column = 1, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },*/
                new FormulierToelichting { Row = 7, Column = 2, Columns = 8, ToelichtingText = "Let op!Het omrekenen van nettobedragen naar brutobedragen (bruteren) is verplicht als de vennootschap de dividendbelasting voor eigen rekening neemt." },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create Afdrachtverminderingen section.
        /// </summary>
        /// <returns>Return nieuwe section.</returns>
        private FormulierSectie AfdrachtverminderingenSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 12,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 10,
                Title = "Afdrachtverminderingen",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
               new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
               new FormulierVraag { Row = 2, Column = 0, Columns = 4, Text = "Vermindering van dividendbelasting vanwege in het buitenland geheven bronbelastingop deelnemingsdividenden bij dooruitdeling (artikel 11)" },
               new FormulierAntwoord { Row = 2, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 3, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
               new FormulierVraag { Row = 3, Column = 0, Columns = 4, Text = "Het bedrag aan ingehouden dividendbelasting als gevolg van het afzien van de vrijstelling van dividendbelasting vanwege in het buitenland geheven bronbelasting opwinstuitkeringen (artikel12)" },
               new FormulierAntwoord { Row = 3, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 4, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
               new FormulierVraag { Row = 4, Column = 0, Columns = 4, Text = "Subtotaal afdrachtverminderingen" },
               new FormulierAntwoord { Row = 4, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 5, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "d" },
               new FormulierVraag { Row = 5, Column = 0, Columns = 4, Text = "Dividendbelasting die is ingehouden op uitkeringen aan eenfiscale beleggingsinstelling (artikel11a)" },
               new FormulierAntwoord { Row = 5, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 6, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "e" },
               new FormulierVraag { Row = 6, Column = 0, Columns = 4, Text = "Buitenlandse bronbelasting die is ingehouden op uitkeringen aan een fiscale beleggingsinstelling (artikel 11a)" },
               new FormulierAntwoord { Row = 6, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 7, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "f" },
               new FormulierVraag { Row = 7, Column = 0, Columns = 4, Text = "Totaal afdrachtverminderingen" },
               new FormulierToelichting { Row = 8, Column = 8, Columns = 3, ToelichtingText = "Vul in bij 8e in de verzamelstaat." },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create Verzamelstaat section.
        /// </summary>
        /// <returns>Return nieuwe section.</returns>
        private FormulierSectie VerzamelstaatSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 13,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 11,
                Title = "Verzamelstaat",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
               new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
               new FormulierVraag { Row = 2, Column = 0, Columns = 4, Text = "Ingehouden dividendbelasting op uitkeringen met 15% dividendbelasting. Neem over van vraag 4d." },
               new FormulierAntwoord { Row = 2, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 3, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
               new FormulierVraag { Row = 3, Column = 0, Columns = 4, Text = "Ingehouden dividendbelasting op uitkeringen met verdragspercentage. Neem over van vraag 5d." },
               new FormulierAntwoord { Row = 3, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 4, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
               new FormulierVraag { Row = 4, Column = 0, Columns = 4, Text = "Dividendbelasting bijzondere situaties. Neem over van vraag 6c." },
               new FormulierAntwoord { Row = 4, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 5, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "d" },
               new FormulierVraag { Row = 5, Column = 0, Columns = 4, Text = "Tel op: 8a t/m 8c. Subtotaal inhoudingen" },
               new FormulierAntwoord { Row = 5, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 6, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "e" },
               new FormulierVraag { Row = 6, Column = 0, Columns = 4, Text = "Af: Afdrachtverminderingen. Neem over van vraag 7f." },
               new FormulierAntwoord { Row = 6, Column = 2, Columns = 2, SoortAntwoord = SoortAntwoord.Nummer },

               new FormulierVraag { Row = 7, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "f" },
               new FormulierVraag { Row = 7, Column = 0, Columns = 4, Text = "Totaal te betalen dividendbelasting" },
               new FormulierToelichting { Row = 8, Column = 2, Columns = 8, ToelichtingText = "Maak dit bedrag over op rekeningnummer nl26 ingb 0000 4412 90 van de Belastingdienst in Apeldoorn. Vermeld ook uw aangiftenummer." },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create Aanvullende informatie section.
        /// </summary>
        /// <returns>Return nieuwe section.</returns>
        private FormulierSectie AanvullendeinformatieSection()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 14,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 12,
                Title = "Aanvullende informatie",
            };
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
               new FormulierAntwoord { Row = 2, Column = 2, Columns = 8, SoortAntwoord = SoortAntwoord.Textarea },
            };
            formulierSectie.SectionKinderen = formulierVraagen;

            return formulierSectie;
        }

        /// <summary>
        /// Create een niuwe section Element.
        /// </summary>
        /// <returns>Niuwe element.</returns>
        private FormulierElement CreateOndertekeningSection()
        {
            List<FormulierAntwoord> formulierantwoorden = new List<FormulierAntwoord>()
            {
            };

            // voeg de elementen to
            List<FormulierElement> formulierVraagen = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 2, Column = 2, Columns = 2, Text = "Naam contactpersoon", Antwoorden = formulierantwoorden },
                new FormulierAntwoord { Row = 2, Column = 0, Columns = 6, SoortAntwoord = SoortAntwoord.Text },

                new FormulierVraag { Row = 3, Column = 2, Columns = 2, Text = "Functie" },
                new FormulierAntwoord { Row = 3, Column = 0, Columns = 6, SoortAntwoord = SoortAntwoord.Text },
                new FormulierVraag { Row = 4, Column = 2, Columns = 2, Text = "Plaats" },
                new FormulierAntwoord { Row = 4, Column = 0, Columns = 6, SoortAntwoord = SoortAntwoord.Text },
                new FormulierVraag { Row = 5, Column = 2, Columns = 2, Text = "Telefoon" },
                new FormulierAntwoord { Row = 5, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text },
                new FormulierVraag { Row = 6, Column = 2, Columns = 2, Text = "Handtekening" },
                new FormulierAntwoord { Row = 6, Column = 0, Columns = 3, SoortAntwoord = SoortAntwoord.Text },
                new FormulierToelichting { Row = 6, Column = 2, Columns = 4, ToelichtingText = "Zet op elke bijlage de naam en het RSIN/fiscaal nummer van de vennootschap." },
            };

            return new FormulierSectie()
            {
                Row = 15,
                Rows = 1,
                Column = 1,
                Columns = 11,
                SectionNumber = 13,
                Title = "Ondertekening",
                SectionKinderen = formulierVraagen,
            };
        }
    }
}
