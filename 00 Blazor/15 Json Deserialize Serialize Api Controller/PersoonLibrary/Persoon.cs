using System;
using System.Collections.Generic;
using System.Text;

namespace PersoonLibrary
{
    public class Persoon
    {
        public Persoon(string name, string age)
        {
            this.Naam = name;
            this.Age = age;
        }
        public string Naam { get; set; }
        public string Age { get; set; }
    }
}
