using System;
using System.Collections.Generic;
using System.Text;

namespace PersoonLibrary
{
    public class Employee : Persoon
    {
        public Employee(string name,string age, bool isWorking):base(name,age)
        {
            this.IsWorking = isWorking;
        }
        public bool IsWorking { get; set; }
    }
}
