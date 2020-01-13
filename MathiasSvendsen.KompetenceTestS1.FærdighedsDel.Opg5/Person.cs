using System;
using System.Collections.Generic;
using System.Text;

namespace MathiasSvendsen.KompetenceTestS1.FærdighedsDel.Opg5
{
    class Person
    {
        // Fields
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private TimeSpan age;
        private int ageYears;

        // Constructor
        public Person(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Age = age;
            AgeYears = ageYears;
        }

        // Properties
        // First name
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        // Last name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        // Birthdate
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
        // Age
        public TimeSpan Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int AgeYears
        {
            get 
            {
                return ageYears; 
            } 
            set
            { 
                ageYears = value;
            } 
        }

        // Metoder
        public void CalculateAge(DateTime birthdate)
        {
            DateTime now = DateTime.Now;
            age = now - birthdate;

            for(ageYears = 0; ageYears < age.TotalDays / 365.2 - 1; ageYears++)
            {

            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Personens information:");
            Console.WriteLine($"Fornavn er : {firstName}");
            Console.WriteLine($"Efternavn er: {lastName}");
            Console.WriteLine($"Fødselsdato er: {birthdate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Alder er: {ageYears} år\n");
        }

    }
}