using System;
using System.Collections.Generic;

namespace ListReview
{
    class Program
    {

        //This function takes a list and returns a single integer
        static int Average(List<int> nums)
        {
            int accum = 0;
            foreach (int next in nums)
            {
                accum += next;
            }
            return accum / nums.Count;
        }


        //This function takes a single number and creates and fiils a list
        static List<int> FillList(int count)
        {
            List<int> mylist = new List<int>();
            for (int i = 0; i < count; i++)
            {
                mylist.Add(i * 2);
            }
            return mylist;
        }

        //This function prints out a list
        static void PrintList(List<int> mylist)
        {
            Console.WriteLine($"\nThis list has {mylist.Count}. Here's what's in the list:");
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine($"Index {i} contains {mylist[i]}.");
            }
        }

        //This function increments each item in the list by 1
        static void ChangeList(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i] + 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Create a list!");
            List<int> sizes = new List<int>() { 5, 10, 15, 20 };

            Console.WriteLine("Let's get the average!");
            Console.WriteLine(Average(sizes));

            Console.WriteLine("\nLet's fill a list and print it!");
            List<int> thelist = FillList(6);
            PrintList(thelist);
            //PrintList(FillList(6)); // gives same output ^

            Console.WriteLine("\nLet's change the items in the list and print it");
            ChangeList(thelist);
            PrintList(thelist);

            Console.WriteLine("\nLet's reverse this thing!!");
            thelist.Reverse();
            PrintList(thelist);

            Console.WriteLine("\nLet's manually change a couple items");
            thelist[2] = 50;
            thelist[4] = 100;
            thelist.Add(101);
            thelist.RemoveAt(3);
            PrintList(thelist);

            Console.WriteLine("\nLet's sort the list!");
            thelist.Sort(); // sorts the list in order from numerical value
            PrintList(thelist);

            Console.WriteLine("\nLet's remove 50 from it!");
            thelist.Remove(50);
            PrintList(thelist);

        }
    }
}
