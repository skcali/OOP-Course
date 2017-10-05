using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // Inherit from Employee Class
    class TechnicalEmployee : Employee
    {
        public TechnicalEmployee(String name) : base(name, 75000)
        {

        }

        // Creates integer variable called "SuccessfulCheckIns" and assigns value to 5
        public int SuccessfulCheckIns = 5;

        // This method returns the toString() method - which is the employee's ID number and name - and prints the number of successful check ins the employee has had
        public override string EmployeeStatus()
        {
            return this.toString() + " has " + this.SuccessfulCheckIns + " successful check ins";
        }
    }
}
