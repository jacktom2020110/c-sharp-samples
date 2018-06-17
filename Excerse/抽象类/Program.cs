using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager myManager = new Manager();

            myManager.Login();
            myManager.EatLunch();

            Console.ReadLine();
        }
    }
}
