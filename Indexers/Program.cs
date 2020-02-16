using System;
using System.Collections.Generic;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car {Name = "Audi", Number = "AA1327BC"},
                new Car {Name = "Ford", Number = "DC4313DD"},
                new Car {Name = "Mustang", Number = "DD0951CC"}
            };
            var parking = new Parking();
            foreach (var car in cars)
                parking.AddCar(car);
            foreach(var car in parking)
                Console.WriteLine(car);
            Console.ReadLine();
        }
    }
}
