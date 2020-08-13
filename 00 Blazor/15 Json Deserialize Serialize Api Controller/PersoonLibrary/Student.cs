using System;
using System.Collections.Generic;
using System.Text;

namespace PersoonLibrary
{
    public class Student : Persoon
    {
        public Student(string name, string age, bool isMale) : base(name, age)
        {
            this.IsMale = isMale;
        }
        public bool IsMale { get; set; }
    }
}
