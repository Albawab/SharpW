using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> nummers = new List<int>();
            nummers.Add(1);
            nummers.Add(2);
            nummers.Add(3);
            nummers.Add(4);
            foreach(int num in nummers){
                Console.WriteLine( num.ToString());
            }

            int[] nummur = new int[3];
            nummur[0] = 1;
            nummur[1] = 2;

            foreach (int num in nummur)
            {
                nummur[2] = 3;
                Console.WriteLine(num.ToString());
            }
        }
    }
}
