using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FindSumOfFirst10NaturalNumbers
{
    class Program
    {
        /* The following code is Find the Sum of First 10 Natural Numbers
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #22
         * Date: 2018-03-09 */
        static void Main(string[] args)
        {
            WriteLine("It sum the first 10 natural numbers.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show the sum of first 10 natural numbers:");
            WriteLine();
            int number = 0;
            int sum = 0;
            Write("The first 10 natural number is: ");
            for (number = 1; number <= 10; number++)
            {
                Write("{0} ", number);
                sum = sum + number;
            }
            WriteLine();
            Write("The sum is: {0}", sum);
            ReadLine();
        }
    }
}