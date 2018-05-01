using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace NOddAndTheirSum
{
    class Program
    {
        /* The following code is Display the n Terms of Odd and Their Sum
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Problem Statement #26
         * Date: 2018-03-13 */
        static void Main(string[] args)
        {
            WriteLine("It display the n terms of odd natural numbers and their sum.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the n terms of odd natural numbers and their sum:");
            WriteLine();
            int number = 0;
            int sum = 0;
            Write("Input number of terms: ");
            number = ToInt32(ReadLine());
            WriteLine();
            Write("The odd numbers are: ");
            for (int n = 1; n <= (number * 2); n = (n + 2))
            {
                Write("{0} ", n);
                sum = sum + n;
            }
            WriteLine();
            Write("The Sum of odd Natural Number up to {0} terms is: {1}", number, sum);
            WriteLine();
            ReadLine();
        }
    }
}
