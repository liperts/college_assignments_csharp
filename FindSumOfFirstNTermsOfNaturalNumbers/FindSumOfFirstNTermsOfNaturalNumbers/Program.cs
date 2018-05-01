using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace FindSumOfFirstNTermsOfNaturalNumbers
{
    class Program
    {
        /* The following code is Find the Sum of First N Terms of Natural Numbers
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #23
         * Date: 2018-03-09 */
        static void Main(string[] args)
        {
            WriteLine("It sum the first n terms of natural numbers.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show the sum of first n terms of natural numbers:");
            WriteLine();
            int number = 0;
            int sum = 0;
            Write("Please input a number: ");
            number = ToInt32(ReadLine());
            Write("The first {0} natural number is: ", number);
            for (int n = 1; n <= number; n++)
            {
                Write("{0} ", n);
                sum = sum + n;
            }
            WriteLine();
            Write("The sum of natural number up to {0} terms is: {1}", number, sum);
            ReadLine();
        }
    }
}
