using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDabLab
{
    class Movies
    {
        private string Title;
        private string Category;

        public Movies(string title, string category)
        {
            Title = title;
            Category = category;
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

            Movies Twilight = new Movies("Twilight", "Romance");
            Movies WarmBodies = new Movies("Warm Bodies", "Scifi");
            Movies LoveJones = new Movies("Love Jones", "Romance");
            Movies GirlsTrip = new Movies("Girl's Trip", "Comedy");
            Movies Avatar = new Movies("Avatar", "Scifi");
            Movies Soul = new Movies("Soul", "Animated");
            Movies DJango = new Movies("DJango", "Drama");
            Movies TheVillage = new Movies("The Village", "Drama");
            Movies TheIncredibles = new Movies("The Incredibles", "Animated");
            Movies BAPS = new Movies("BAPS", "Comedy");


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
                Console.WriteLine("Pick the movie category you'd like to view: \n1.Scifi    2. Romance  3.Comedy   4.Drama  5.Animated :");
                string entry = Console.ReadLine().ToLower();
                Console.WriteLine($"You chose {entry}");

                if (entry == "scifi")
                {
                    Console.WriteLine("This category contains these films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == entry)
                        {
                            Console.WriteLine(movie.GetTitle());
                        }
                    }
                }
                else if (entry == "romance")
                {
                    Console.WriteLine("This category contains these films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == entry)
                        {
                            Console.WriteLine(movie.GetTitle());
                        }
                    }
                }
                else if (entry == "comedy")
                {
                    Console.WriteLine("This category contains these films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == entry)
                        {
                            Console.WriteLine(movie.GetTitle());
                        }
                    }
                }
                else if (entry == "drama")
                {
                    Console.WriteLine("This category contains these films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == entry)
                        {
                            Console.WriteLine(movie.GetTitle());
                        }
                    }
                }
                else if (entry == "animated")
                {
                    Console.WriteLine("This category contains these films:\n");
                    foreach (Movies movie in MovieList)
                    {
                        if (movie.GetCategory().ToLower() == entry)
                        {
                            Console.WriteLine(movie.GetTitle());
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
