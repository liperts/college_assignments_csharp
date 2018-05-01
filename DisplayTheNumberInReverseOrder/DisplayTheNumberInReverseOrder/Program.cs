using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace DisplayTheNumberInReverseOrder
{
    class Program
    {
        /* The following code is to Display the Number in Reverse Order
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #10
         * Date: 2018-03-23 */
        static void Main(string[] args)
        {
            WriteLine("It displays the number in reverse order.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the number in reverse order:");
            WriteLine();
            int number = 0;
            int reverse = 0;
            Write("Please input a number to reverse: ");
            number = ToInt32(ReadLine());
            WriteLine();
            while (number <= 0)
            {
                Write("A number to reverse should be positive. Please try again: ");
                number = ToInt32(ReadLine());
                WriteLine();
            }

            ReadLine();
        }
    }
}
