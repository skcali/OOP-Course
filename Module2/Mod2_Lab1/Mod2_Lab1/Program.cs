using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee Object with name Libby and salary 2000 called employee1
            var Employee1 = new Employee("Libby", 2000);

            // Instantiates TechnicalEmployee Object with name Zaynah called Employeed2
            var Employee2 = new TechnicalEmployee("Zaynah");

            // Instantiates BuisnessEmployee Object with name Wither called Employee3
            var Employee3 = new BuisnessEmployee("Winter");

            // Output to the console window
            Console.WriteLine(Employee1.EmployeeStatus() + "..." + Employee2.EmployeeStatus() + "..." + Employee3.EmployeeStatus());
        }
    }
}
