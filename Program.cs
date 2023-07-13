using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                // Check if the number is positive, negative, or zero
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }

                // Check if the number is even or odd using the conditional operator
                string parity = (number % 2 == 0) ? "even" : "odd";
                Console.WriteLine("The number is " + parity + ".");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
