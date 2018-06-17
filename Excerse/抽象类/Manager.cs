using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Manager : Employee
    {
        public string Department { get; set; }

        public override void EatLunch()
        {
            Console.WriteLine("Manager is eating lunch");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Login()
        {
            //base.Login(); 调用抽象类的方法
            Console.WriteLine("Manager Login");
        }

        public override void LogOff()
        {
            base.LogOff();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
