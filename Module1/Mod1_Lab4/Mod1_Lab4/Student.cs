using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab4
{
    class Student
    {
        public string StudentName { get; set; }
        private static int counter = 0;

        // Contructor
        public Student(string studentName)
        {
            this.StudentName = studentName;
            counter++;
        }

        // Increments how many students there are everytime a new one is created
        public static int CountStudents()
        {
            return counter;
        }
    }
}
