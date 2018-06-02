using System;

namespace ClassDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p1 = new Person("Jac",25,"男");

            

            Person p2 = p1;
            p2.Name = "Kite";

            Console.WriteLine($" p1.name is {p1.Name}\r\n p2.name is {p2.Name}");

            p1.Beat();
            /*
            Person[] moreP = {
                new Person{Name="bob", Age=15, Gender="Male"},
                new Person{Name="Dick", Age=14, Gender="Female"},
                new Person{Name="Tom", Age=18, Gender="Male"}
            
                

            };
            */
            foreach (var item in moreP)
            {
                Console.WriteLine(item.Name);
            }




            Console.ReadLine();
        }
    }
}
