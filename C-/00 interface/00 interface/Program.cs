using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();

            ICar car = new Start();
            Console.WriteLine(car.Naam());
            Console.WriteLine(car.oud());

            Console.WriteLine(((IDriver)start).Naam());

           int i = ((IDriver)start).oud();

            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
