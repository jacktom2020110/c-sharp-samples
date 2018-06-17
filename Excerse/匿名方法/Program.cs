using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    delegate void SayGeeting(string m);

    class Program
    {
        static void Main(string[] args)
        {

            SayGeeting sg = new SayGeeting(SayChinese);
            sg("Jack");

            SayGeeting sg1 = m => Console.WriteLine($"你好，{m} 帅哥！");
            sg1("John");




            Console.ReadLine();


        }

        static void SayChinese(string m)
        {
            Console.WriteLine($"你好，{m}");
        }
    }
}
