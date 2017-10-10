using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Student1 = new Student("Sean", "Cali", "Philosophy");
            var Student2 = new Student("Ryan", "Simpkins", "Buisness");
            var Student3 = new Student("Jamie", "Cordrey", "Buisness");

            var Teacher1 = new Teacher("Mike", "Strawser", "Philosophy");

           /* Console.WriteLine(Student1.TestStatus(true));
            Console.WriteLine(Student2.TestStatus(false));
            Console.WriteLine(Student3.TestStatus(true));
            Console.WriteLine(Teacher1.TestStatus(false)); */


            // Creates StreamReader object called "streamReaderObject"
            // Assigns its value to null
            StreamReader streamReaderObject = null;
            StreamWriter streamWriterObject = null;

            try
            {
                using (streamWriterObject = new StreamWriter("file1.txt"))
                {
                    streamWriterObject.WriteLine(Student1.TestStatus(true));
                    streamWriterObject.WriteLine(Student2.TestStatus(false));
                    streamWriterObject.WriteLine(Student3.TestStatus(true));
                    streamWriterObject.WriteLine(Teacher1.TestStatus(false));
                }

                streamWriterObject.Close();
                streamWriterObject.Dispose();
                // Assigns "streamReaderObject" to read from a text file named "file1"
                streamReaderObject = new StreamReader("file1.txt");

                // Reads all characters from the current position to the end of the stream
                // Stores in String variable "contents"
                String contents = streamReaderObject.ReadToEnd();

                // Closes StreamReader
                streamReaderObject.Close();

                // Writes the amount of text elements in the text file to the Console
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }

            // Code to handle any errors
            catch (FileNotFoundException)
            {
                //Informs user there is no file created
                Console.WriteLine("The file cannot be found.");
            }

            // Invoking the Dispose method in a finally block
            // Note that code in finally block will always execute
            finally
            {
                // Checks if object is not null
                if (streamReaderObject != null)

                    // Calls upon the Dispose method
                    // Releases all resources used by the TextReader object
                    streamReaderObject.Dispose();
            }
        }
    }
}
