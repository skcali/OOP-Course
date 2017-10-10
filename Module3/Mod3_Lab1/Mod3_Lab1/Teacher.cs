using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string courseName) : base(firstName, lastName, courseName)
        {

        }

        public override string TestStatus(bool PassOrFail)
        {
            PassOrFail = true;
            return toString() + " has graded the papers";
        }
    }
}
