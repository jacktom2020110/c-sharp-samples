using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual void Login()
        {
            Console.WriteLine("Employee Login");
        }

        public virtual void LogOff()
        {
            Console.WriteLine("Employee Logff");
        }

        public abstract void EatLunch();

       
    }
}
