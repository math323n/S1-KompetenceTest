using System;

namespace MathiasSvendsen.KompetenceTestS1.FærdighedsDel.Opg2
{
    class Program
    {
        static void Main()
        {
            // Declare for loop 
            for(int i = 1; i != 11; i++)
            {
                // Store int seventable & multiply with 1, up to 10 times.
                int sevenTable = 7 * i;

                Console.WriteLine(sevenTable);
            }
        }
    }
}