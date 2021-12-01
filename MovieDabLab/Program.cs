using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDabLab
{
    class Movies
    {
        private string Title;
        private string Category;
        public int Year;

        public Movies(string title, string category, int year)
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

            Movies Twilight = new Movies("Twilight", "Romance", 2008);
            Movies WarmBodies = new Movies("Warm Bodies", "Scifi", 2012);
            Movies LoveJones = new Movies("Love Jones", "Romance", 1994);
            Movies GirlsTrip = new Movies("Girl's Trip", "Comedy", 2017);
            Movies Avatar = new Movies("Avatar", "Scifi", 2012);
            Movies Soul = new Movies("Soul", "Animated", 2020);
            Movies DJango = new Movies("DJango", "Drama", 2017);
            Movies TheVillage = new Movies("The Village", "Drama", 2013);
            Movies TheIncredibles = new Movies("The Incredibles", "Animated", 2010);
            Movies BAPS = new Movies("BAPS", "Comedy", 1996);


            List<Movies> MovieList = new List<Movies>();
            MovieList.Add(Twilight);
            MovieList.Add(WarmBodies);
            MovieList.Add(LoveJones);
            MovieList.Add(GirlsTrip);
            MovieList.Add(Avatar);
            MovieList.Add(Soul);
            MovieList.Add(DJango);
            MovieList.Add(TheVillage);
            MovieList.Add(TheIncredibles);
            MovieList.Add(BAPS);

            do
            {
                Console.WriteLine("\nChoose the number of the movie category you'd like to view: \n[1] Scifi    [2] Romance  [3] Comedy   [4] Drama  [5] Animated :");
                string entry = Console.ReadLine().ToLower();
                int numChoice = int.Parse(entry);
                Console.WriteLine($"You chose option {entry}");

                if (numChoice == 1)
                {
                    Console.WriteLine("\nThis category contains the following films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "scifi")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.Year);
                        }
                    }
                }
                else if (numChoice == 2)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "romance")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.Year);
                        }
                    }
                }
                else if (numChoice == 3)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "comedy")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.Year);
                        }
                    }
                }
                else if (numChoice == 4)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "drama")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.Year);
                        }
                    }
                }
                else if (numChoice == 5)
                {
                    Console.WriteLine("This category contains the following films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == "animated")
                        {
                            Console.WriteLine(movie.GetTitle() + "-" + movie.Year);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sorry! That's not one of the categories. Please try again.");
                }
            } while (GoAgain("Would you like to continue? Y/N :"));

            Console.WriteLine("Thanks for exploring! See you next time!");
        }
    }
}
