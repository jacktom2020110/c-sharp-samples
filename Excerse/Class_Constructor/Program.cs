using System;

namespace Class_Constructor
{

    class Person
    {
        public Person()
        {
            Console.WriteLine("Public Constructor was executed");
        }

        static Person()
        {
            Console.WriteLine("static Constructor was executed");
        }

        public static void Show()
        {
            Console.WriteLine("你在调用静态方法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Person p1 = new Person();
            // 当实例化时，静态构造先执行，非静态后执行
            // Person p1 = null;

            Person.Show();

            Console.ReadLine();

        }
    }
}
