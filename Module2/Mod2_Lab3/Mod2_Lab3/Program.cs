using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Student1 = new Student("Sean", "Cali", "Philosophy");
            var Student2 = new Student("Ryan", "Simpkins", "Buisness");
            var Student3 = new Student("Jamie", "Cordrey", "Buisness");

            var Teacher1 = new Teacher("Mike", "Strawser", "Philosophy");

            Console.WriteLine(Student1.TestStatus(true));
            Console.WriteLine(Student2.TestStatus(false));
            Console.WriteLine(Student3.TestStatus(true));
            Console.WriteLine(Teacher1.TestStatus(false));
        }
    }
}
