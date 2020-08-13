using System;
using System.Threading;

namespace Timing_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // timing over 1 minuts.
            //                  (hours, min, sec);
            TimeSpan timeSpan = new TimeSpan(/*h*/0, /*min*/1, /*s*/0);
            while (true)
            {
                Thread.Sleep(timeSpan);
                Console.WriteLine(DateTime.Now);
            }
        }
    }
}
