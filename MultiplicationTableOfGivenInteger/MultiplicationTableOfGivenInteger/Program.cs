using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MultiplicationTableOfGivenInteger
{
    class Program
    {
        /* The following code is Display the Multiplication Table of a Given Integer
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Problem Statement #25
         * Date: 2018-03-13 */
        static void Main(string[] args)
        {
            WriteLine("It display the multiplication table of a given integer.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the multiplication table of a given integer:");
            WriteLine();
            int number = 0;
            int result = 0;
            Write("Input a number to see it Table of Multiplication: ");
            number = ToInt32(ReadLine());
            WriteLine();
            for (int n = 1; n <= 10; n++)
            {
                result = number * n;
                Write("{0} X {1} = {2}", number, n, result);
                WriteLine();
            }
            ReadLine();
        }
    }
}