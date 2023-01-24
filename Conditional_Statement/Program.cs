/*
Author: Shea Newton
Date: 1/24/2023
Description: This C# console application provides a practical example of conditional statements
*/

using System; //calling the library

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try statement to find out letter grade
            try
            {
                Console.WriteLine("What grade do you expect to get in ISM 4300? ");
                int n1 = int.Parse(Console.ReadLine());
                //If statement for F grade
                if ((n1 >= 0) && (n1 <= 59))
                {
                    Console.WriteLine("Your letter grade is F");
                }
                //If statement for D grade
                if ((n1 >= 60) && (n1 <= 69))
                {
                    Console.WriteLine("Your letter grade is D");
                }
                //If statement for C grade
                if ((n1 >= 70) && (n1 <= 79))
                {
                    Console.WriteLine("Your letter grade is C");
                }
                //If statement for B grade
                if ((n1 >= 80) && (n1 <= 89))
                {
                    Console.WriteLine("Your letter grade is B");
                }
                //If statement for A grade
                if (n1 >= 90)
                {
                    Console.WriteLine("Your letter grade is A");
                }


            }
            //Catch statement to prevent users from inputing anything other than integers
            catch
            {
                Console.WriteLine("Please use a integer number");
                Console.ReadKey(true);
            }


        }
    }
}