// <copyright file="AangifteSchenkbelasting.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// De aangifte schenk belasting.
    /// </summary>
    public class AangifteSchenkbelasting : Formulier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AangifteSchenkbelasting"/> class.
        /// </summary>
        public AangifteSchenkbelasting()
    : base("Aangifte Schenkbelasting")
        {
            List<FormulierElement> elementen = new List<FormulierElement>();
            elementen.Add(this.AddGegevensOntvangerSector());
            this.Kinderen = elementen;
        }

        private FormulierElement AddGegevensOntvangerSector()
        {
            FormulierSectie formulierSectie = new FormulierSectie()
            {
                Row = 1,
                Rows = 1,
                Column = 1,
                Columns = 10,
                Title = "Gegevens ontvanger",
                SectionNumber = 1,
            };
            List<FormulierElement> formulierElements = new List<FormulierElement>()
            {
                new FormulierVraag { Row = 1, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "a" },
                new FormulierVraag
                {
                    Row = 1, Column = 0, Columns = 2, Text = "Is de ontvanger een instelling of bedrijf?", Antwoorden = new List<FormulierAntwoord>()
                {
                    new FormulierAntwoord { Row = 1, Rows = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Nee.Ga verder met vraag 1d." },
                    new FormulierAntwoord { Row = 1, Rows = 1, Column = 0, Columns = 2, SoortAntwoord = SoortAntwoord.CheckBox, AntwoordToelichting = "Ja.Ga verder met vraag 1b." },
                },
                },

                new FormulierVraag { Row = 2, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "b" },
                new FormulierVraag
                {
                    Row = 2, Column = 0, Columns = 2, Text = "Naam instelling of bedrijf", Antwoorden = new List<FormulierAntwoord>()
                {
                  new FormulierAntwoord { Row = 2, Column = 0, Columns = 6, SoortAntwoord = SoortAntwoord.Text },
                },
                },

                new FormulierVraag { Row = 3, Column = 1, Columns = 1, Text = formulierSectie.SectionNumber.ToString() + "c" },
                new FormulierVraag
                {
                    Row = 3, Column = 0, Columns = 2, Text = "RSIN/fiscaal nummer", Antwoorden = new List<FormulierAntwoord>()
                {
                  new FormulierAntwoord { Row = 3, Column = 0, Columns = 6, SoortAntwoord = SoortAntwoord.Text, AntwoordToelichting = "Ga verder met vraag 2." },
                },
                },
            };

            formulierSectie.SectionKinderen = formulierElements;
            return formulierSectie;
        }
    }
}
