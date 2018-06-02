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


    }
}
