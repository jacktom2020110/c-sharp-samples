using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承示例
{
    class TechnicalEmployee : Employees
    {
        public int sucessfulCheckIns = 5;

        public TechnicalEmployee(string name): base(name,1000)
        {

        }

        public override string EmployeeStatus()
        {
            return this.ToString() + "has " + this.sucessfulCheckIns + " successful check ins";
        }
    }
}
