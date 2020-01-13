using System;
using System.IO;
using System.Text;

namespace MathiasSvendsen.KompetenceTestS1.FærdighedsDel.Opg6
{
    class Program
    {

        static string path = @"C:\Users\math323n\Documents\kompetencetest\streamwriterfilen.txt";
        static void Main()
        {
            // Display the main menu to window
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            // Menu text
            Console.WriteLine(
                "-- - Menu ---\n" +
                "1. Se alt indhold i tekstfilen\n" +
                "2. Skriv til tekstfilen\n" +
                "3. Afslut programmet"
                );
            // Get the user input
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                // Goto display content.
                DisplayTextFileContent();
            }
            else if(userInput == "2")
            {
                // Goto add content
                AddContentToFile();
            }
            else if(userInput == "3")
            {
                // Exit program
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Fejl, prøv igen");
                DisplayMenu();
            }
        }

        static void DisplayTextFileContent()
        {
            // Clear screen
            Console.Clear();
            // Use StreamReader to display text
            using(StreamReader reader = new StreamReader(path))
            {
                // Read the stream to a string, and write the string to the console.
                String line = reader.ReadToEnd();
                Console.WriteLine(line);
            }
            // Go back to menu
            DisplayMenu();
        }
        static void AddContentToFile()
        {
            // Clear screen
            Console.Clear();
            // Display menu
            Console.WriteLine(
                "1. Skriv til tekstfilen\n" +
                "2. Tilbage til hovedemenuen\n");
            // Get input
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                // StreamWriter
                using(StreamWriter writer = new StreamWriter(path, true, Encoding.Default))
                {
                    // Writing...
                    Console.WriteLine("Skriv din tekst her:");
                    string text = Console.ReadLine();
                    writer.WriteLine(text);
                }
                // Go back to start start of method
                AddContentToFile();
            }
            else if(userInput == "2")
            {
                // Go to menu
                DisplayMenu();
            }
            else
            {
                // Incorrect input handling
                Console.WriteLine("Fejl, prøv igen.");
                AddContentToFile();
            }


        }
    }
}
