using System;

namespace NumberGuesseer
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();


            while (true)
            {
                // Set correct numer
                // int correctNumber = 7;

                // Create a new Random object.
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "Please enter an actual number.");
                    }
                    // Cast to int and put in guess
                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Green, "Wrong number , please try again.");
                    }
                }
                PrintColorMessage(ConsoleColor.Cyan, "You are CORRECT!!!");

                // Ask to play again.
                Console.WriteLine("Play Again [Y or N]");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Gusser";
            string appVirsion = "1.0.0";
            string appAuthor = "Brad Traversy";

            // change text color
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("{0}: version {1} by {2}", appName, appVirsion, appAuthor);
            // Reset color.
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask user name
            Console.WriteLine("Wat is je naam?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hallo {0} let's play a game ....", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
