using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承示例
{
    abstract class Employees
    {
        private static int employeeCount = 1;

        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public double EmploySalary { get; set; }
        public int EmployID { get; set; }

        public Employees(string name, double baseSarly)
        {
            this.EmployeeName = name;
            this.EmploySalary = baseSarly;
            this.EmployID = employeeCount++;
        }

        public double GetSalary()
        {
            return this.EmploySalary;
        }

        public string ToString()
        {
            return this.EmployID + "  " + this.EmployeeName;
        }

        public abstract string EmployeeStatus();
        //{
        //    return ToString() + " is in the company's system";
        //}
    }
}
