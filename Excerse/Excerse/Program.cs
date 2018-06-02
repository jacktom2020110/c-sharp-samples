using System;

namespace Excerse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("输入2个数：");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}",x,y,Sum(x,y));
            */

            int ret = GetMax(new int[] { 2, 3, 4, 5, 6 });

            Console.WriteLine(ret);


            int a = 100;
            Change(ref a);

            Console.WriteLine("a={0}",a);

            
            string strOut;

            Change(ref a, out strOut);

            Console.WriteLine("a={0}\r\n strOut={1}",a,strOut);

            Console.ReadLine();



        }


        // 输入 2个数，返回其和
        static int Sum(int x, int y)
        {
            return x + y;
        }


        // 给定一个INT数组，返回数组中的最大值
        static int GetMax(int[] intArray)
        {
            int ret = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                ret = Math.Max(ret, intArray[i]);
            }
            return ret;
        }


        // Ref 示例
        static void Change(ref int a)
        {
            a = 30;
        }

        // Out 示例
        static void Change(ref int a, out string ret)
        {
            a = 80;
            ret = "hello";
        }
    }
}
