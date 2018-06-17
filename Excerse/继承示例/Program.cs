using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承示例
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager myManger = new Manager();

            //myManger.Department = "IT";

            //var employee1 = new TechnicalEmployee("Jack", 2000);

            var employee1 = new TechnicalEmployee("Dick");

            var employee3 = new BusinessEmployee("Bob");

            Console.WriteLine(employee1.EmployeeStatus() + "\r\n"+
                
                employee1.EmployeeStatus()+"\r\n"+employee3.EmployeeStatus());

            Console.ReadLine();
        }
    }
}
