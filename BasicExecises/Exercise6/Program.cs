/*Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. */
/*Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
-------------------------------------
Expected Output:
2 x 3 x 6 = 36*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         Exercise 6                         ");
            Console.WriteLine("------------------------------------------------------------");

            int num1, num2, num3, sum;                                          //Variables declared

            Console.WriteLine("\nEnter first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter second number to multiply: ");           //User input
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());

            sum = num1 * num2 * num3;                                           //Equation method to be called

            Console.Write("\n{0} * {1} * {2} = {3}", num1, num2, num3, sum);    //Output to user
            Console.ReadLine();

        }
    }
}
