using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresLab
{
    class Program
    {

        static string ReverseString(string entry)
        {
            string output = "";

            Stack<char> wordcharacters = new Stack<char>();
            foreach (char letter in entry)
            {
                wordcharacters.Push(letter);
            }
            while (wordcharacters.Count > 0)
            {
                output += wordcharacters.Pop();
            }

            return output;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter something you'd like to reverse: ");
            string entry = Console.ReadLine();

            ReverseString(entry);

            Console.WriteLine(ReverseString(entry));
        }
    }
}
