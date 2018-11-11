/*Write a C# Sharp program that takes a number as input and print its multiplication table. 
 ------------------------------------------------------------------------------------------
 Test Data:
Enter the number: 5
-------------------------------------------------------------------------------------------
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10 
5 * 3 = 15
....
5 * 10 = 50*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         Exercise 8                         ");
            Console.WriteLine("------------------------------------------------------------");

            int num;
            int result;
            start:
            Console.WriteLine("\nEnter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            result = num * 0;
            Console.WriteLine("\n{0} * {1} = {2}", num, 0, result);
            result = num * 1;
            Console.WriteLine("{0} * {1} = {2}", num, 1, result);
            result = num * 2;
            Console.WriteLine("{0} * {1} = {2}", num, 2, result);
            result = num * 3;
            Console.WriteLine("{0} * {1} = {2}", num, 3, result);
            result = num * 4;
            Console.WriteLine("{0} * {1} = {2}", num, 4, result);
            result = num * 5;
            Console.WriteLine("{0} * {1} = {2}", num, 5, result);
            result = num * 6;
            Console.WriteLine("{0} * {1} = {2}", num, 6, result);
            result = num * 7;
            Console.WriteLine("{0} * {1} = {2}", num, 7, result);
            result = num * 8;
            Console.WriteLine("{0} * {1} = {2}", num, 8, result);
            result = num * 9;
            Console.WriteLine("{0} * {1} = {2}", num, 9, result);
            result = num * 10;
            Console.WriteLine("{0} * {1} = {2}", num, 10, result);
            Console.ReadLine();                                    
        }
    }
}
