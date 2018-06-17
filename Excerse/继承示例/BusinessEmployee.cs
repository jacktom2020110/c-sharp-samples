using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承示例
{
    class BusinessEmployee : Employees
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 50000)
        {

        }

        public override string EmployeeStatus()
        {
            //return base.employeeStatus();
            return ToString() + " with a budget of " + this.bonusBudget;
        }
    }
}
