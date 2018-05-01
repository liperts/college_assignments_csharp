using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CalculatingNFactorial
{
    class Program
    {
        /*The following code is Calculating N Factorial (N!)
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Student No: 300963168
         * Group No: 02
         * Assignment #06-Problem Statement #30
         * Date: 2018-03-14 */
        static void Main(string[] args)
        {
            WriteLine("The program is Calculating N Factorial");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            int numberInt, count;
            int nFactorial = 0;
            Write("Please, input an integer and non-negative number: ");
            numberInt = ToInt32(ReadLine());
            while (numberInt < 0)
            {
                Write("Please input an integer and non-negative number. Try again: ");
                numberInt = ToInt32(ReadLine());
                WriteLine();
            }
            if (numberInt == 0)
            {
                nFactorial = 1;
                Write("The value of 0! is {0}.", nFactorial);
            }
            else 
            {
                nFactorial = numberInt;
                for (count = numberInt; (count - 1) > 1; count--)
                {
                    nFactorial = nFactorial * (count - 1);
                }
                Write("The value of {0}! is {1}.", numberInt, nFactorial);
                WriteLine();
            }
            ReadLine();
        }
    }
}