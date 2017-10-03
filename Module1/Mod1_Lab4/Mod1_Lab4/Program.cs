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

            // Instantiate new Programing with C# course
            Course Programming = new Course();

            // Add teacher and student objects
            Programming.Students = new Student[3];
            Programming.Teachers = new Teacher[1];
            Programming.Students[0] = new Student("Sean");
            Programming.Students[1] = new Student("Kenji");
            Programming.Students[2] = new Student("Cali"); ;
            Programming.Teachers[0] = new Teacher("Mr. Teacher");

            // Instatiate new degree
            Degree Bachelor = new Degree();

            Bachelor.Courses = Programming;

            // Instantiate new IT program
            UProgram ITProgram = new UProgram();

            // Include degree object into new IT program object
            ITProgram.Degrees = Bachelor;
            
            // Set the amount of students
            var countStudents = Student.CountStudents();

            // Print to console
            Console.WriteLine($"There is a {ITProgram} path that will get you a {ITProgram.Degrees}'s degree");
            Console.WriteLine($"The course name is {ITProgram.Degrees.Courses}");
            Console.WriteLine($"The number of students in the course is {countStudents}");
            Console.ReadLine();
        }
    }
}
