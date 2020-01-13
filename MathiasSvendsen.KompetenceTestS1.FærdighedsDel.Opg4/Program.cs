using System;

namespace MathiasSvendsen.KompetenceTestS1.FærdighedsDel.Opg4
{
    class Program
    {
        static void Main()
        {
            // Get first user input
            Console.WriteLine("Indtast kun tal over 0.\n");
            Console.Write("Indtast dit første tal: ");
            string firstInput = Console.ReadLine();
            // Get second user input
            Console.Write("Indtast dit andet tal: ");
            string secondInput = Console.ReadLine();

            // Attempt to parse input to Integer
            bool canParseFirstNumber = double.TryParse(firstInput, out double firstNumber);
            bool canParseSecondNumber = double.TryParse(secondInput, out double secondNumber);
            // If can parse the number
            if(canParseFirstNumber && canParseSecondNumber)
            {
                // Check if a number is 0, to prevent divide by zero error
                if(firstNumber != 0 || secondNumber != 0)
                {
                    Calculation(firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("Du kan ikke indtaste 0 tal.");
                    // Call Main() to restart program
                    Main();
                }
            }
            else
            {
                Console.WriteLine("Du kan kun indtaste tal.");
                // Call Main() to restart program
                Main();
            }
            Console.ReadLine();
        }

        // Method for Calculation of user input numbers & printing them out.
        static void Calculation(double firstNumber, double secondNumber)
        {
            // Calculation of user numbers
            double addition = firstNumber + secondNumber;
            double subtracted = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double division = firstNumber / secondNumber;
            double modulus = firstNumber % secondNumber;

            // Print the results to console
            Console.WriteLine(
                $"Addition: {addition}\n" +
                $"Subtraktion: {subtracted}\n" +
                $"Multiplikation: {multiplication}\n" +
                $"Division: {division:f}\n" +
                $"Modulus: {modulus}");
        }
    }
}