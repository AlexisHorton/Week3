using System;
using System.Collections.Generic;

namespace AnimalsDemo
{
    class Animal
    {
        public int NumberOfCells;
        public Animal()
        {
            NumberOfCells = 0;
        }
        public Animal(int noCells)
        {
            NumberOfCells = noCells;
        }

        public override string ToString()
        {
            return $"This animal has {NumberOfCells} cells.";
        }

    }

    class Bird : Animal
    {
        public int LengthOfBeak;
        public Bird()
        {
            LengthOfBeak = 1;
        }
        public Bird(int loBeak, int noCells) : base(noCells)
        {
            LengthOfBeak = loBeak;
        }

        public override string ToString()
        {
            return $"This bird has {NumberOfCells} cells and its beak is {LengthOfBeak} inches long.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            Animal a1 = new Animal(1000);
            Animals.Add(a1);

            Console.WriteLine(a1);

            Bird b1 = new Bird(25, 50);
            Animals.Add(b1);

            Console.WriteLine(b1);
        }
    }
}
