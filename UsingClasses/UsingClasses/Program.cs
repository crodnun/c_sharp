using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // We use another class from main program here
            Console.WriteLine("Running ...");

            FirstClass myObj = new FirstClass(10, "MyFirstClass");

            // Use getters and setters
            Console.WriteLine("Getters values {0} {1}", myObj.getId(), myObj.getName());

            // modify 
            myObj.setId(20);
            myObj.setName("Name modified");

            // get again
            Console.WriteLine("Getters values {0} {1}", myObj.getId(), myObj.getName());

            Console.ReadKey();
        }
    }
}
