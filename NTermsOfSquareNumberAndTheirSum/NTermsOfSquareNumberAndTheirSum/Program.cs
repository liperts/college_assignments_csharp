using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace NTermsOfSquareNumberAndTheirSum
{
    class Program
    {
        /* The following code is Display the N Terms Of Square Number and Their Sum
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #7
         * Date: 2018-03-18 */
        static void Main(string[] args)
        {
            WriteLine("It display the n terms of square number and their sum.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the n terms of square number and their sum:");
            WriteLine();
            int number = 0;
            double square = 0;
            double sum = 0;
            Write("Input number of terms: ");
            number = ToInt32(ReadLine());
            while (number <= 0)
            {
                Write("The number of terms should be positive. Please try again: ");
                number = ToInt32(ReadLine());
                WriteLine();
            }
            Write("The square natural up to {0} terms are: ", number);
            for (double count = 1; count <= number; count++)
            {
                square = Pow(count, 2);
                Write("{0} ", square);
                sum = sum + square;
            }
            WriteLine();
            Write("The Sum of Square Natural Number up to {0} terms = {1}", number, sum);
            WriteLine(ReadLine());
        }
    }
}
