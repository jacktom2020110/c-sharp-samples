using System;

namespace MultiShape
{

    //定义枚举类型

    public enum Seaons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    class Animal
    {
        public string Name { get; set; }
        public int age { get; set; }

        public virtual void Show()
        {

            Console.WriteLine("Animal Show");
        }
    }

    class Dog : Animal {

        public string Gender { get; set; }

        /*
        //隐藏父类show方法
        public new void Show()
        {

            Console.WriteLine("Dog Show");
        }
        */

        // 使用override来重写父类的虚函数（virtual）
        public override void Show() {
            Console.WriteLine("Dog Show");
        }
    }

    class Tiger : Animal {

    }

    class Panda : Animal { }
    class Lion : Animal { }
    class Snake : Animal { }
    class Elephent : Animal { }



    class Program
    {
        static void Main(string[] args)
        {

            /*
            Dog d = new Dog();
            d.Name = "";
            d.age = 5;
            d.Gender = "";

            Animal a = d;
            a.Name = "";
            a.age = 2;

            Dog d2 = d as Dog;
            d.Gender = "";

            */




            Console.WriteLine("Hello World!");
            //CalculateAnimal(new Lion());

            Dog d1 = new Dog();

            d1.Show();


            //如何时使用一个枚举

            Seaons s = Seaons.Summer;
            Console.WriteLine(s);
            Console.WriteLine(s+1);
            Console.ReadLine();
        }

        static void CalculateAnimal(Animal a) {
            // Animal a = new Lion()
            //判断a是什么类型的动物？这里判断是否是Lion

            if (a is Lion)
            {
                Console.WriteLine("这是一个狮子");
            }
        }
    }
}
