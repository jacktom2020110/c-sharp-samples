using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edx_sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Color = "Yellow";
            car1.Year = 2010;
            car1.Mileage = 11000;

            var car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();
            Console.WriteLine($"There are {carCount} cars on inventory right now");
            Console.WriteLine($"This car is painted {car1.Color}, was built in {car1.Year}, and has {car1.Mileage} miles on it.");

            Console.ReadLine();

        }
    }
}
