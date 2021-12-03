using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDabLab
{
    class Movie
    {
        private string Title;
        private string Category;
        private int Year;

        public Movie(string title, string category, int year)
        {
            Title = title;
            Category = category;
            Year = year;
        }

        public string GetCategory()
        {
            return Category;
        }

        public string GetTitle()
        {
            return Title;
        }

        public int GetYear()
        {
            return Year;
        }
    }

    class Program
    {
        static bool GoAgain(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string entry = Console.ReadLine();
                if (entry.ToLower() == "n")
                {
                    return false;
                }
                if (entry.ToLower() == "y")
                {
                    return true;
                }
                Console.WriteLine("Oops! Please enter something valid.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");

            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(new Movie("Twilight", "Romance", 2008));
            MovieList.Add(new Movie("Warm Bodies", "Scifi", 2012));
            MovieList.Add(new Movie("Love Jones", "Romance", 1997));
            MovieList.Add(new Movie("Girl's Trip", "Comedy", 2017));
            MovieList.Add(new Movie("Avatar", "Scifi", 2009));
            MovieList.Add(new Movie("Soul", "Animated", 2020));
            MovieList.Add(new Movie("DJango", "Drama", 2012));
            MovieList.Add(new Movie("The Village", "Drama", 2004));
            MovieList.Add(new Movie("The Incredibles", "Animated", 2005));
            MovieList.Add(new Movie("BAPS", "Comedy", 1994));

            do
            {
                Console.WriteLine($"\nThere are {MovieList.Count} films in this list.");
                Console.WriteLine("\nChoose the number of the movie category you'd like to view: \n[1] Scifi    [2] Romance  [3] Comedy   [4] Drama  [5] Animated :");
                string entry = Console.ReadLine().ToLower();
                int numChoice = int.Parse(entry);
                Console.WriteLine($"You chose option {entry}");

                if (numChoice == 1)
                {
                    Console.WriteLine("\nThis category contains the following films:\n");
                    foreach (Movie movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "scifi")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.GetYear());
                        }
                    }
                }
                else if (numChoice == 2)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movie movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "romance")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.GetYear());
                        }
                    }
                }
                else if (numChoice == 3)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movie movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "comedy")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.GetYear());
                        }
                    }
                }
                else if (numChoice == 4)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movie movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "drama")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.GetYear());
                        }
                    }
                }
                else if (numChoice == 5)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movie movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "animated")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.GetYear());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sorry! That's not one of the categories. Please try again.");
                }
            } while (GoAgain("\nWould you like to continue? Y/N :"));

            Console.WriteLine("Thanks for exploring! See you next time!");
        }
    }
}
