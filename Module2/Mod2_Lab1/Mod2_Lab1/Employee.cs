using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Employee
    {
        // 3 private member variables: EmployeeName, EmployeeBaseSalary, and EmployeeId
        private string EmployeeName;
        private double EmployeeBaseSalary;
        private int EmployeeId;

        // Public properties
        public String Name
        {
            get
            {
                return EmployeeName;
            }
            set
            {
                EmployeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return EmployeeBaseSalary;
            }
            set
            {
                EmployeeBaseSalary = value;
            }
        }

        public int ID
        {
            get
            {
                return EmployeeId;
            }
            set
            {
                EmployeeId = value;
            }
        }

        // Constructor
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = EmployeeCount;
            EmployeeCount++;
        }

        // This method returns the employee's base salary
        public double GetBaseSalary()
        {
            return this.BaseSalary;
        }

        // This method returns the employee's name
        public String GetName()
        {
            return this.Name;
        }

        // Creates integer variable called "EmployeeCount" and assigns value to 1
        private static int EmployeeCount = 1;
        
        // This method returns the employee's ID
        public int GetEmployeeID()
        {
            return this.ID;
        }

        // This method returns the employee's ID and Name
        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        // This method returns the employee's ID and Name and confirms that the employee is in the system
        public virtual String EmployeeStatus()
        {
            return toString() + " is in the company's system";
        }
    }
}
