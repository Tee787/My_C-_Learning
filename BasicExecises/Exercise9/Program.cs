/*9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
 Test Data:
Enter the First number: 10 
Enter the Second number: 15 
Enter the third number: 20 
Enter the four number: 30 

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         Exercise 9                         ");
            Console.WriteLine("------------------------------------------------------------");

            double num1, num2, num3, num4;
            double average;

            Console.WriteLine("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            num4 = double.Parse(Console.ReadLine());

            average = num1 + num2 + num3 + num4 / 4;                            //All numbers divided by 4 equals the average

            Console.Write("The average of all four numbers is {0}: ", average);
            Console.ReadLine();
        }
    }
}
