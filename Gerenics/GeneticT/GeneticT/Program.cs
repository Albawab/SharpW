using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticT
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> intCal = new Calculator<int>();

            Calculator<double> dblCal = new Calculator<double>();

        }
    }

    public class IntCalculator
    {
        public static int Add(int value1, int value2)
        {
            return value1 + value2;
        }
    }
    public class DoubleCalculator
    {
        public static double Add(double value1 , double value2)
        {
            return value1 + value2;
        }
    }

    public class Calculator<T>
    {
        public static T Add(T value1, T value2)
        {
            return value1 + value2;
        }
    }

    // wat is het verschil tussen early en late binding

}
