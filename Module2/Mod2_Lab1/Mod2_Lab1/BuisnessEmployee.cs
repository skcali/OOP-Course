using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // Inheriting from Employee Class
    class BuisnessEmployee : Employee
    {
        // Calls upon base-class (Employee Class) constructor from within derived class (BuisnessEmployee Class)
        // Sets BaseSalary to 50000 for all BuisnessEmployee objects
        public BuisnessEmployee(String name) : base(name, 50000)
        {

        }

        // Create double variable called "BonusBudget" and assigns value to 1000
        public double BonusBudget = 1000;

        // This method returns the toString() method - which is the employee's ID number and name - and prints the bonus budget
        public override string EmployeeStatus()
        {
            return toString() + " with a budget of " + this.BonusBudget;
        }
    }
}
