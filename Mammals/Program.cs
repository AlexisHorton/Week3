using System;

namespace Mammals
{
    class Mammal
    {
        public string TypeOfHair;
        public int NumberOfTeeth;

        public Mammal(string toHair, int noTeeth)
        {
            TypeOfHair = toHair;
            NumberOfTeeth = noTeeth;
        }
    }

    class Cat : Mammal
    {
                  //"retract claws count"
        public int RCCount;
        public Cat(int countClaws, string toHair, int noTeeth) : base(toHair, noTeeth)
        {
            RCCount = countClaws;
        }
    }

    class Dog : Mammal
    {
        public int NumOfTricks;
        public bool IsDomesticated;
        public Dog() : base("none selected", 32)    // my dog's teeth number doesn't get switched...
        {
            NumOfTricks = 0;
            IsDomesticated = true;
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {

            Dog Oso = new Dog();

            Console.WriteLine($"This is Oso's teeth number: {Oso.NumberOfTeeth}");

            Oso.NumOfTricks = 4;
            Oso.IsDomesticated = true;
            Oso.TypeOfHair = "short, tan and soft";
            Oso.NumberOfTeeth = 12;

            Cat Pandy = new Cat(4, "soft black and white", 22);
           
            Dog Bree = new Dog();
            Bree.NumberOfTeeth = 32;
            Bree.IsDomesticated = true;
            Bree.NumOfTricks = 5;
            Bree.TypeOfHair = "short, brown and multi-colored";


            Console.WriteLine($"This is Oso's teeth number: {Oso.NumberOfTeeth}");

            Console.WriteLine($"\nThis is Pandy's number of teeth: {Pandy.NumberOfTeeth}");
        }
    }
}
