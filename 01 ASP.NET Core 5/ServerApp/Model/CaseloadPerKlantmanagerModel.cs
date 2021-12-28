using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Model
{
    public class CaseloadPerKlantmanagerModel
    {
        public Guid? Idactiviteit { get; set; }

        public string Dossierhouder { get; set; }

        public string Bsn { get; set; }

        public string Client { get; set; }

        public string Nummer { get; set; }

        public DateTimeOffset? Begdatum { get; set; }

        public DateTimeOffset? Einddat { get; set; }

        public string Activiteit { get; set; }

        public DateTimeOffset? Gebdatum { get; set; }

        public string Soorttraject { get; set; }

        public string Typetraject { get; set; }

        public Guid? Idtraject { get; set; }

        public int? Vwcaseloadperklantmanagerid { get; set; }
    }
}
