using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Algorithm_1
    {
        static void Main(string[] args)
        {
            /*
        Write a C# Sharp program to check two given integers and return true if one of them is 30 or if their sum is 30.

           */
            try
            {
                //accepting the first value from user 

                Console.WriteLine("Please enter the first number");
                int number1 = int.Parse(Console.ReadLine());

                //accepting the second value from user 
                Console.WriteLine("Please enter the second number");
                int number2 = int.Parse(Console.ReadLine());

                //Using a tenary operator to check for the conditions 
                bool result = (number1 + number2) == 30 || (number1 == 30 || number2 == 30) ? true : false;

                //printing out the result
                Console.WriteLine(result);
                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid Input\nError Message:{0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}
