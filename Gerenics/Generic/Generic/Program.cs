using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Calculator.AreEqual("A", "A")) // string
            {
                Console.WriteLine("Equal.");
            }
            if (Calculator.AreEqual(2, 2)) // int
            {
                Console.WriteLine("String Equal");
            }
        }
    }

    public class Calculator
    {
        public static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }
    }
}
