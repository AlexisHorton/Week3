using System;
using System.Collections.Generic;
using System.Linq;

namespace New_UsedCarsLab
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public decimal Price;

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public static List<Car> CarList = new List<Car>();
        public static void ListCars()
        {
            Console.WriteLine("Here's what's in our inventory: ");
            for (int i = 0; i < CarList.Count; i++)
            {
                Console.WriteLine($"{i + 1} {CarList[i]}");
            }
        }

        public static void Remove(int removeitem)
        {

            removeitem--;
            CarList.RemoveAt(removeitem);

            //for (int i = 0; i < CarList.Count; i++)
            //{
            //    if (removeitem == i)
            //    {
            //        CarList.RemoveAt(i);
            //    }
            //}
        }

        public override string ToString()
        {
            return $"Make: {Make} \t Model: {Model} \t Year: {Year} \t Price: ${Price}";
        }
    }

    class UsedCar : Car
    {
        public double Mileage;

        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"Make: {Make} \t Model: {Model} \t Year: {Year} \t Price: ${Price} \t Mileage: {Mileage}";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dealership!\n");

            Car c1 = new Car("A3", "Audi", 2022, 33900);
            Car c2 = new Car("A4", "Audi", 2021, 39100);
            Car c3 = new Car("Altima", "Nissan", 2023, 48700 );
            UsedCar c4 = new UsedCar("Ford", "Escape", 2018, 17980, 32569);
            UsedCar c5 = new UsedCar("GMC", "YukonXL", 2013, 18450, 178170);
            UsedCar c6 = new UsedCar("MC-Benz", "S 550", 2015, 51500, 46885);

            Car.CarList.Add(c1);
            Car.CarList.Add(c2);
            Car.CarList.Add(c3);
            Car.CarList.Add(c4);
            Car.CarList.Add(c5);
            Car.CarList.Add(c6);

            Car.ListCars();
            Console.WriteLine("Choose your next car:");

            string entry = Console.ReadLine();
            int remove = int.Parse(entry);

            Console.WriteLine($"You chose this car: {Car.CarList[remove-1]}");

            Car.Remove(remove);



            Car.ListCars();

            Console.WriteLine("Super!! Our finance department will be in touch shortly.");
            
            Console.WriteLine("Have a great day!");
        }
    }
}
