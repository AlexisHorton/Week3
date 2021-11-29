using System;
using System.Collections.Generic;

namespace WorkedThruMockAssess
{
    class Program
    {

        static int AddStarWarsCharacters(string[] characters)
        {
            //string searchYoda = "Yoda";
            //int index = Array.IndexOf(characters, searchYoda);
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == "Yoda")
                {
                    return i;
                }
            }
            return -1;
        }

        static string DeathStarCombat(Dictionary<string,int> attacks)
        {
            int highest = 0;
            string jedi = "";

            foreach (var pair in attacks)
            {
                if (pair.Value > highest)   
                {
                    highest = pair.Value;
                    jedi = pair.Key;
                }
            }

            return jedi;
        }

        //Function to get average of even numbers
        static int AverageDroidsWRONG(List<int> droids)
        {
            int sum = 0;
            int count = 0;
            foreach (int droid in droids)
            {
                if (droid %2 == 0)
                {
                    sum += droid;
                    count++;
                }
            }
            return sum / count;

        }

        static int AverageDroids(List<int> droids)
        {
            List<int> evens = new List<int>();
            foreach (int droid in droids)
            {
                if (droid % 2 ==0)
                {
                    evens.Add(droid);
                }
            }

            int sum = 0;
            foreach (int droid in evens)
            {
                sum += droid;
            }
            return sum / evens.Count;
        }

        static string TryToCatchDarthVader(string mystring)  // "123" will PARSE because it's an integer
        {
            try
            {
                int num = int.Parse(mystring);
                return "Vader Was Captured!";
            }
            catch (Exception ex)
            {

               return "Vader Got Away!";
            }
        }

        // Let's write a function called IsInt and it will take a string, and return a bool
        //We will parse the string. If parses successfully, we'll return true
        //                          If it doen't parse, we'll return false
        //Ex:
        //  If I call this function with "123", I should get back True
        //  If I call this function with "abc", I should get back False
        //  If I call this function with "0", I should get back True
        //  If I call this function with "", I should get back False
        //  Requirement: Use try/catch
        static bool IsInt(string mystring)
        {
            try
            {
                int num = int.Parse(mystring);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Testing Yoda search");

            string[] characters1 = new string[] { "Obi wan", "Luke", "Anakin", "Yoda" };
            Console.WriteLine($"Expecting 3: I got {AddStarWarsCharacters(characters1)}"); // expecting 3

            string[] characters2 = new string[] { "Obi wan", "Luke", "Anakin" };
            Console.WriteLine($"Expecting -1: I got {AddStarWarsCharacters(characters2)}"); // Expecting -1

            Dictionary<string, int> attackValues = new Dictionary<string, int>();
            attackValues["Ahsoka"] = 6;
            attackValues["Obi wan"] = 10;
            attackValues["Anakin"] = 9;
            attackValues["Luke"] = 3;

            Console.WriteLine($"Expecting Obi Wan: I got {DeathStarCombat(attackValues)}"); //Expecting Obi Wan

            //List to test AverageDroids
            List<int> droids = new List<int>() { 5, 8, 7, 2, 10, 11, 14, 15 };
            Console.WriteLine($"Expecting 8, got {AverageDroids(droids)}"); // Expect 8

            Console.WriteLine($"Expecting Vader Was Captured!, got {TryToCatchDarthVader("123")}");
            Console.WriteLine($"Expecting Vader Got Away!, got {TryToCatchDarthVader("abc")}");
        }
    }
}
