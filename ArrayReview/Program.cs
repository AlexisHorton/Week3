using System;

namespace ArrayReview
{
    class Program
    {
        // This funcion takes an array and returns a single integer (a scalar).
        static int Average(int[] nums)
        {       //sum
            int accum = 0;
            foreach (int next in nums)
            {
                accum += next;
            }
            return accum / nums.Length;
        }

        //This function takes a count, creates an array of that size, and fills it with numbers
        static int[] FillArray(int count)
        {
            int[] myarray = new int[count];
            //ex: An array of size 5 we will fill with 0, 1, 2, 3, 4.
            // i * 2 will give even output= 0, 2, 4, 6, 8 

            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = i * 2;
            }

            return myarray;
        }

        //This function prints out what's in an array
        static void PrintArray(int[] thearray)
        {
            Console.WriteLine("\nHere's what is in the array");
            for (int i = 0; i < thearray.Length; i++)
            {
                Console.WriteLine($"Index {i} contains {thearray[i]}");
            }
        }


        //This function increments each item in the array
        //For ex, pass in [5, 10, 15, 20],
        //this function will modify that array, changing it to:
        // [6, 11, 16, 21]
        //When we pass an array into a function, 
        // the function has the actual original array, NOT a copy.
        // So any changes we make are changing the original array.
        static void ChangeArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Create an array!");
            int[] sizes = new int[] { 5, 10, 15, 20 };

            Console.WriteLine("\nHere's what is in the array");
            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine($"Index {i} contains {sizes[i]}");
            }

            Console.WriteLine("\nLet's count downn from the end to the beginning!");
            for (int i = sizes.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Index {i} contains {sizes[i]}");
            }

            Console.WriteLine("\nLet's use a foreach loop");
            foreach (int item in sizes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCreate another array without initialization");
            int[] numbers = new int[4];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            //Console.WriteLine(numbers[2]);

            int avg = Average(numbers);
            Console.WriteLine($"The average is {avg}");

            Console.WriteLine($"The average is {Average(numbers)}"); //Same output as above

            Console.WriteLine("\nLet's call our FillArray method to create an array!");
            int[] morenums = FillArray(5);
            PrintArray(morenums);

            Console.WriteLine("\nCreate an array and pass it to our ChangeArray method.");
            int[] tochange = new int[] { 5, 10, 15, 20 };
            ChangeArray(tochange);
            PrintArray(tochange);
        }
    }
}
