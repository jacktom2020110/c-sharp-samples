using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edx_sample1
{
    public class Car
    {

        private static int instances = 0;
        //定义属性
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

       
        public Car()
        {
            instances++;
        }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}
