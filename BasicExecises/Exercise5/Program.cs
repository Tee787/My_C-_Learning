/*5. Write a C# Sharp program to swap two numbers. */
/*Test Data:
Input the First Number : 5
Input the Second Number : 6
/**/
/*Expected Output: 
After Swapping :
First Number : 6 
Second Number : 5 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         Exercise 5                         ");
            Console.WriteLine("------------------------------------------------------------");

            int num1, num2, temp;                                   //Variables used

            Console.WriteLine("\nEnter first number:\n ");          //Input to user
            num1 = int.Parse(Console.ReadLine());                   //Number conversion
            Console.WriteLine("\nEnter second number:\n ");         //Input to user
            num2 = int.Parse(Console.ReadLine());                   //Number conversion

            temp = num1;
            num1 = num2;                                            //Number swap method
            num2 = temp;

            Console.WriteLine("\nAfter swapping: ");                //Result output
            Console.WriteLine("\nFirst number: "+num1);             //Result output
            Console.WriteLine("\nSecond number: "+num2);            //Result output
            Console.ReadLine();
        }
    }
}
