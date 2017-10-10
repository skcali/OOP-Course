using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    abstract class Person : IDisposable
    {
        private string First_Name;
        private string Last_Name;
        private string Course_Name;
        bool _isDisposed;

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

        // Implement IDisposable interface
        public void Dispose()
        {
            // Invoking overloaded Dispose method then instruct GC that resources have been released
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Check if object has been disposed, if so throw exception
        public void OpenWordDocument(string filePath)
        {
            if (this._isDisposed)
                throw new ObjectDisposedException("Person");
        }

        // Overload implementation of Dispose method to dispose of managed or unmanaged resources
        protected virtual void Dispose(bool isDisposing)
        {
            if (this._isDisposed)
                return;
            if (!isDisposing)
            {
                if (isDisposing)
                {
             
                }
            }
            // Always release unmanaged resources

            // Indicate that the object has been disposed
            this._isDisposed = true;
        }

        // Destructor
        ~Person()
        {
            Dispose(false);
        }
    }
}
