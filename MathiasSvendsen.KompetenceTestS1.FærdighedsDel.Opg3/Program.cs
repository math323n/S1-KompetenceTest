using System;

namespace MathiasSvendsen.KompetenceTestS1.FærdighedsDel.Opg3
{
    class Program
    {
        static void Main()
        {
            // Generator for random number
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
           
            while(true)
            {
                // Ask for input & store in string
                Console.Write("Gæt et tal mellem 1 & 10: ");
                string userInput = Console.ReadLine();

                // Attempt to parse input to Integer
                bool success = int.TryParse(userInput, out int userGuess);
                // If userInput is a number
                if(success)
                {
                    // If guess is true
                    if(userGuess == randomNumber)
                    {
                        Console.WriteLine($"Du gættede rigtigt. Tallet var {randomNumber}");
                        // End program
                        break;
                    }
                    // If guess is false
                    else
                    {
                        Console.WriteLine("Det var det forkerte tal, prøv igen.");
                    }
                }
                // If cannot parse to integer
                else
                {
                    Console.WriteLine("Du indtastede ikke et tal.");
                }
            }
        }
    }
}