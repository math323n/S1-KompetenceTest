using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MathiasSvendsen.KompetenceTestS1.KompetenceDel
{
    class Program
    {
        // Fields
        // Path to string, very important.
        static string path = @"C:\Users\math323n\Documents\film.txt";
        // Fields List for storing each film.
        static List<Film> films = new List<Film>();

        /* Main method, checks if there is content in the txt file on startup 
        * to prevent errors & displays menu */
        static void Main()
        {
            // Code to enter menu or create a new film if the List is empty.
            if (ReadFile() == true)
            {
                // Display the main menu screen
                DisplayMenu();
            }
            else
            {
                // If .txt file is empty, user must make new film.
                Console.WriteLine("Fejl der er ingen film, lav venligst en ");
                EnterNewFilm();
            }
        }

        // Read the file, checking for errors, and appending to list.
        static bool ReadFile()
        {
                // Use streamreader, and filestream, to store the text inside the txt file inside the List.
                using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line;
                            // Reading the entire document
                            while ((line = reader.ReadLine()) != null)
                            {
                            // Try Catch
                                try
                                {
                                    string[] words = line.Split(",");

                                    if(!int.TryParse(words[1], out int wordAsInt))
                                    {
                                        return false;
                                    }
                                    // Create the object using the text
                                    Film movie = new Film(words[0], wordAsInt, words[2], words[3]);
                                    // Append to List films
                                    films.Add(movie);
                                }
                                catch(IndexOutOfRangeException)
                                {
                                // Cathces whitespace in txt file
                                }
                            }
                        }
                    }
                }
            return true;
        }

        // Display the menu
        static void DisplayMenu()
        {
            // Menu text
            Console.WriteLine(
                "----- Menu -----\n" +
                "1. Gem en ny film\n" +
                "2. Se alle film\n" +
                "3. Søg på en film\n" +
                "4. Afslut program"
                );
            // Get the user input
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                // Goto create new film
                EnterNewFilm();
            }
            else if (userInput == "2")
            {
                // Goto view all films
                DisplayFilms();
            }
            else if (userInput == "3")
            {
                // Goto search for movie
                SearchForFilm();
            }
            else if(userInput == "4")
            {
                // Close program
                Environment.Exit(1);
            }
            else
            {
                // Error handling and go to menu
                Console.WriteLine("Fejl, prøv igen");
                DisplayMenu();
            }
        }

        // Enter a new film with this Method
        static void EnterNewFilm()
        {
            // Get the title of the film
            Console.Write("Indtast filmens titel: ");
            string filmTitle = Console.ReadLine();

            // Get the date of film
            Console.Write("Indtast filmens udgivelsesår: ");
            // Parse the string to a number
            string filmReleaseYearAsString = Console.ReadLine();
            bool canParseFilmDate = int.TryParse(filmReleaseYearAsString, out int filmDate);

            // If can parse the number
            if (canParseFilmDate)
            {
                // Continues the code below the else statement
            }
            else
            {
                // Write error message to user & goes to start of method
                Console.WriteLine("Fejl, prøv igen.");
                EnterNewFilm();
            }

            // Get the director of the film
            Console.Write("Indtast filmens instruktør: ");
            string filmDirector = Console.ReadLine();

            // Get the production company of the film
            Console.Write("Indtast filmselskabet: ");
            string FilmProductionCompany = Console.ReadLine();

            // Code to process film and add to list.
            Film newFilm = new Film(filmTitle, filmDate, filmDirector, FilmProductionCompany);
            films.Add(newFilm);

            using (StreamWriter file = new StreamWriter(path, true))
            {
            // Write a new line in document, pass in the film as text & stores it for later.    
             file.WriteLine(newFilm.Title + "," + newFilm.Date + "," + newFilm.Director + "," + newFilm.ProductionCompany);
            }
            // Goto menu
            DisplayMenu();
        }

        // Display all films to user
        static void DisplayFilms()
        {
            // Clear screen
            Console.Clear();
            // Use StreamReader to display text
            using (StreamReader reader = new StreamReader(path))
            {
                // Reader
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Look through words, split them
                    string[] words = line.Split(",");

                    // Tryparse that just works, Main method prevents errors.
                    int.TryParse(words[1], out int wordAsInt);
                    
                    // Get the film into a variable called movie 
                    Film movie = new Film(words[0], wordAsInt, words[2], words[3]);
                    
                    // Write the movies to console window
                    Console.WriteLine(
                     $"Titel: {movie.Title}\n" +
                     $"Udgivelsesår: {movie.Date}\n" +
                     $"Film instruktør: {movie.Director}\n" +
                     $"Produktions selskabet: {movie.ProductionCompany}\n");
                }
            }
            // Wait for input to continue
            Console.WriteLine("Tryk en tast for at fortsætte...");
            Console.ReadKey();
            // Clear console window
            Console.Clear();

            // Goto menu when above code is done
            DisplayMenu();
        }

        // Search for a film inside the list films
        static void SearchForFilm()
        {
            // Clear console window
            Console.Clear();

            // Ask for users input & store in string
            Console.WriteLine("Søg efter en titel på en film.");
            Console.Write("Indtast titel: ");
            string userInput = Console.ReadLine();

            // Enumerator to search for film
            IEnumerable<Film> result = films.Where(film => film.Title.ToLower().Contains(userInput.ToLower()));

            // Searches & writes results if film is found
            Console.WriteLine("\nFølgende film blev fundet:");
            foreach (Film film in result)
            {
                Console.WriteLine(
                 $"Titel: {film.Title}\n" +
                 $"Udgivelsesår: {film.Date}\n" +
                 $"Film instruktør: {film.Director}\n" +
                 $"Produktions selskabet: {film.ProductionCompany}\n");
            }
            // Wait for input to continue
            Console.WriteLine("Tryk en tast for at fortsætte...");
            Console.ReadKey();
            // Clear console window
            Console.Clear();
            // Goto menu
            DisplayMenu();
        }
    }
}