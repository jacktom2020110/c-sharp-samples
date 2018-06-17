using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{

    //声明一个有参数的委托
    delegate void SayGeeting(string m);

    class Program
    {
        static void Main(string[] args)
        {
            //实例化委托sg，将方法SayChinese进行实例化
            SayGeeting sg = new SayGeeting(SayChinese);

            //委托调用传实参
            sg("Jack");

            //等号后面的m为形参， => 右面是方法执行体
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
