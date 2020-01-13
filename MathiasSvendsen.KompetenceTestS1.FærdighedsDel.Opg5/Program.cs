using System;

namespace MathiasSvendsen.KompetenceTestS1.FærdighedsDel.Opg5
{
    class Program
    {
        static void Main()
        {
            // First persons birthdate
            DateTime firstBirthdate = new DateTime(1872, 11, 22);
            // Create first person
            Person firstPerson = new Person("Henrik", "Larsen", firstBirthdate);

            // Second persons birthdate
            DateTime secondBirthdate = new DateTime(1972, 2, 16);
            // Create second person
            Person secondPerson = new Person("Erik", "Knudsen", firstBirthdate);

            // Call methods for first person
            firstPerson.CalculateAge(firstBirthdate);
            firstPerson.PrintInfo();

            // call methods for second person
            secondPerson.CalculateAge(secondBirthdate);
            secondPerson.PrintInfo();
        }
    }
}