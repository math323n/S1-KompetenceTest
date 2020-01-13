using System;

namespace MathiasSvendsen.KompetenceTestS1.FærdighedsDel.Opg1
{
    class Program
    {
        static void Main()
        {
            // Ask for first name of user & store as string
            Console.Write("Indtast dit fornavn: ");
            string firstName = Console.ReadLine();

            // Ask for & get last name of user
            Console.Write("Indtast dit efternavn: ");
            string lastName = Console.ReadLine();

            // Print result to user
            Console.WriteLine($"Du hedder {firstName} {lastName}");
        }
    }
}