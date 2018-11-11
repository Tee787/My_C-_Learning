/*1. Write a C# Sharp program to print Hello and your name in a separate line.*/
/*Expected Output : 
Hello: Alexandra Abramov*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExecises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         Exercise 1                         ");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("\nEnter your first name:\n ");             //User input
            string fname = Console.ReadLine();                          //String variable used for fname and lname
            Console.WriteLine("\nNow enter your surname:\n ");
            string lname = Console.ReadLine();

            Console.Write("\nHello! {0}" + " " + "{1}", fname, lname);  //Output to the console
            Console.ReadLine();
        }
    }
}
