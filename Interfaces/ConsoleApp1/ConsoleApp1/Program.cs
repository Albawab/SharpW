namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using HenE.Werkers;
    using Interface;
    using Werkers;
    class Program
    {
        static void Main(string[] args)
        {
            AddData addData = new AddData();
            List<IDoeEten> doeEtens = addData.VoegDataIn();
            List<IDoeWerk> doeWerks = new List<IDoeWerk>();

            foreach (IDoeEten werker in doeEtens)
            {
                Console.WriteLine($"Ik kan {werker.Koken()} koken. ");

                if (werker is Moeder moder)
                {
                    if (moder.Age > 40)
                    {
                        Console.WriteLine($"{moder.Naam} is ouder dan 40 jaar.Zij is {moder.Age} jaar oud.");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Kan je koken, J of N ?");
            ConsoleKeyInfo anwoord = Console.ReadKey();
            while (anwoord.Key != ConsoleKey.J && anwoord.Key != ConsoleKey.N)
            {
                Console.WriteLine("Geef maar een correct antwoord J of N.");
                anwoord = Console.ReadKey();
            }
            Console.WriteLine();
            string naam = string.Empty;
            if (anwoord.Key == ConsoleKey.J)
            {
                Console.WriteLine("Fijn dat je kan koken.");
                Console.WriteLine("Wil je je naam vertelen.");
                naam = Console.ReadLine();

                Console.WriteLine("Wil je lid in onze team worden, J of N?");
                ConsoleKeyInfo anwoordLid = Console.ReadKey();
                while (anwoordLid.Key != ConsoleKey.J && anwoordLid.Key != ConsoleKey.N)
                {
                    Console.WriteLine("Geef maar een correct antwoord J of N.");
                    anwoordLid = Console.ReadKey();
                }

                Console.WriteLine();

                if (anwoordLid.Key == ConsoleKey.J)
                {

                    doeEtens.Add(new Vader() { Naam = naam });
                    foreach (IDoeEten werker in doeEtens)
                    {
                        if (werker is Vader vader)
                        {
                            if (vader.Naam == naam)
                            {
                                Console.WriteLine($"{vader.Naam} je bent welkom in onze team.");
                            }
                        }
                    }
                }

                if (anwoordLid.Key == ConsoleKey.N)
                {
                    Console.WriteLine($"Oke, Tot Ziens.");
                }

                Console.WriteLine("Wil je lid blijven J of N?");
                anwoord = Console.ReadKey();
                while (anwoord.Key != ConsoleKey.J && anwoord.Key != ConsoleKey.N)
                {
                    Console.WriteLine("Geef maar een correct antwoord J of N.");
                    anwoord = Console.ReadKey();
                }

                Console.WriteLine();
                if (anwoord.Key == ConsoleKey.N)
                {
                    IDoeEten deletedWerker = null;
                    string deletedNaam = string.Empty;
                    foreach (IDoeEten werker in doeEtens)
                    {
                        if (werker is Vader vader)
                        {
                            deletedWerker = werker;
                            deletedNaam = vader.Naam;
                        }
                        deletedWerker = werker;
                    }
                    doeEtens.Remove(deletedWerker);
                    Console.WriteLine($"{deletedNaam}, Je gegevens zijn verwijderen.");
                }
            }
            else
            {
                Console.WriteLine("Helaas.");
            }

            // In het restaurant
            Console.WriteLine("Wat wil je eten?");
            string deKlantWilEten = Console.ReadLine();
            foreach (IDoeEten werker in doeEtens)
            {
                if (werker is Chef chef)
                {
                    Console.WriteLine(chef.WatKlantenHebbenNodig(deKlantWilEten));
                    Console.WriteLine("Eet samkelijk !!");
                }
            }

            Console.WriteLine("Ben je klaar J of N?");
            anwoord = Console.ReadKey();
            Console.WriteLine();
            while (anwoord.Key != ConsoleKey.J && anwoord.Key != ConsoleKey.N)
            {
                Console.WriteLine("Geef maar een correct antwoord J of N.");
                anwoord = Console.ReadKey();
            }

            while (anwoord.Key == ConsoleKey.N)
            {
                Console.WriteLine("Oke, dan wacht ik op je. Als je klaar bent, dan geef maar een antwoord J.");
                anwoord = Console.ReadKey();
            }

            if (anwoord.Key == ConsoleKey.J)
            {
                doeWerks.Add(new Ober() { });

                foreach (IDoeWerk ober in doeWerks)
                {
                    Console.WriteLine(ober.WatKlantenHebbenNodig("Het rekening")); ;
                }
            }

            Console.ReadKey();

            List<Persoon> personen = new List<Persoon>();

            Chef chef = new Chef();
            Ober ober1 = new Ober();
            Klant klant = new Klant();
            Persoon moederc = new Persoon(new EtensVoorkeurPizza());

            //conversatie
            string gewensteEten = ober1.VraagWatDeKlantWiltEten(klant);
            
            string eten = chef.WatKlantenHebbenNodig(gewensteEten);

            klant.Eet(eten);
                       
            klant.VraagOmDeRekening(ober1);


            


            /*de ober vraagt aan de klant, 
             * wat wilt u eten?
             * de klant antwoord met "pizza" 
             * */


        }
    }
}
