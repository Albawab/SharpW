using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_interface
{

    interface IA1
    {
        string A { get; set; }
        void Print();
    }

    class PrintClass : IA1
    {
        string IA1.A { get; set; }

        public void Print()
        {
            Console.WriteLine("Print");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintClass print = new PrintClass();
            // print. No thing because we must call the interface

            IA1 printIterface = new PrintClass();
            printIterface.Print();
            printIterface.A = "a";
            Console.WriteLine(printIterface.A);

            Console.ReadLine();
        }
    }
}
