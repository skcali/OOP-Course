using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Student : Person
    {
        public Student(string firstName, string lastName, string courseName) : base(firstName, lastName, courseName)
        {

        }

        public override string TestStatus(bool PassOrFail)
        {
            if (PassOrFail == true)
            {
                return toString() + " has passed the test";
            }
            else
            {
                return toString() + " has failed the test";
            }

        }
    }
}
