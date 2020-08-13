using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface
{
    interface ICar
    {
       int Model();
    }

    interface IDriver
    {
        string Naam();
    }

    class Car : ICar
    {
        public int Model()
        {
            return 3;
        }
    }

    class Driver : IDriver
    {
        public string Naam()
        {
            return "Ali";
        }
    }

    class Speed : ICar, IDriver
    {
        Car car = new Car();
        Driver driver = new Driver();
        
        public int Model()
        {
            return car.Model();
        }

        public string Naam()
        {
            return driver.Naam();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Speed speed = new Speed();
            Console.WriteLine(speed.Model());
            Console.WriteLine(speed.Naam());
            Console.ReadKey();

        }
    }
}
