using System;

namespace TryCatchReview
{
    class Program
    {
        //Function that makes sure user input is a number(integer)
        // & converts string entry to int (parse)
        static int ReadInt()
        {
            bool done = false;
            int result = 0;
            while (!done)
            {
                string entry = Console.ReadLine();
                try
                {
                    Console.WriteLine("Time to call parse!");
                    result = int.Parse(entry);
                    done = true;
                    Console.WriteLine("Everything looks good, setting done to true.");
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Sorry, that isn't an integer. Please try again."); ;
                }
                Console.WriteLine("Last line of the loop!");
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int num = ReadInt();
            Console.WriteLine($"You entered {num}.");
        }
    }
}
