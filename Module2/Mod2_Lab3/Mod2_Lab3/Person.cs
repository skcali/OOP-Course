using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
    abstract class Person
    {
        private string First_Name;
        private string Last_Name;
        private string Course_Name;

        public string FirstName
        {
            get
            {
                return First_Name;
            }
            set
            {
                First_Name = value;
            }
        }

        public string LastName
        {
            get
            {
                return Last_Name;
            }
            set
            {
                Last_Name = value;
            }
        }

        public string CourseName
        {
            get
            {
                return Course_Name;
            }
            set
            {
                Course_Name = value;
            }
        }

        // Constructor
        public Person(string firstName, string lastName, string courseName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CourseName = courseName;
        }

        // Method returns first and last name and what course they are in
        public string toString()
        {
            return this.FirstName + " " + this.LastName + " is in the class " + this.CourseName;
        }

        // Abstract method
        public abstract string TestStatus(bool PassOrFail);
    }
}
