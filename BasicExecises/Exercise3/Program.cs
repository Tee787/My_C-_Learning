/*3. Write a C# Sharp program to print the result of dividing two numbers*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         Exercise 3                         ");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("\nEnter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNow enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 / num2;

            Console.Write("\n{0} / {1} = {2}", num1, num2, sum);
            Console.ReadLine();
        }
    }
}
