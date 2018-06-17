using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    // 声明技能
    public static class Skill
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 invoked");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 invoked");
        }

        public static void ShootGun()
        {
            Console.WriteLine("ShootGun invoked");
        }

    }
    // 声明一个技能委托
    public delegate void SkillDelegate();

    // 声明一个英雄
    public class Hero
    {
        public SkillDelegate q;
    }

    public delegate int CalculateMethod(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            // 实例化英雄
            // 可以将方法名直接赋值给委托类型
            Hero jack = new Hero();
            jack.q = Skill.Method1;

            Hero bob = new Hero();
            bob.q = Skill.Method2;

            Hero tom = new Hero();
            tom.q = Skill.ShootGun;

            Hero Dick = new Hero();

            Dick.q = () => Console.WriteLine("Dick");


            jack.q();
            bob.q();
            tom.q();
            Dick.q();


            Func<string> func = () => "Hello";

            string a = func();

            Console.WriteLine(a);

            Console.ReadKey();    
        }
    }
}
