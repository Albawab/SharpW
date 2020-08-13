using System;
using System.Collections.Generic;
using System.Text;

namespace Json
{
    class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<string> Courses { get; set; }
        public Car Car { get; set; }
    }
}
