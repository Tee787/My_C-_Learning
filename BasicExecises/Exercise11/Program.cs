/*11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"
 Test Data:
Enter your age - 25
Expected Output:
You look older than 25*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {   //Guessing the age
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         Exercise 11                        ");
            Console.WriteLine("------------------------------------------------------------");

            int age;

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age > 25)                                             //If statement for age greater than 25
            {
                Console.WriteLine("You look older than 25.");
            }
            else if (age < 25)                                        //Else if for age less than 25
            {
                Console.WriteLine("You look younger than 25.");
            }
            else if(age == 25)                                        //Else if for age equal to 25
            {
                Console.WriteLine("You look old enough to be 25.");
            }
            Console.ReadLine();
                
        }
    }
}
