using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDesign
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public int Height { get; set; }
        public int High { get; set; }

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person(string name, int age, string gender, int height, int high)
            :this(name,age,gender)
        {
            this.Height = height;
            this.High = high;
        }

        public void Eat()
        {
            Console.WriteLine(Name + " eat something");
        }

        public void Sleep()
        {
            Console.WriteLine(Name+"is sleeping");
        }

        public void Beat()
        {
            Console.WriteLine(Name + "is playing");
        }

    }
}
