using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace PerfectNumberOrNot
{
    class Program
    {
        /* The following code is to Check Whether a Given Number is Perfect or Not
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #8
         * Date: 2018-03-19 */
        static void Main(string[] args)
        {
            WriteLine("It check whether a given number is perfect number or not.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check whether a given number is perfect number or not:");
            WriteLine();
            int number = 0;
            int divisor = 1;
            int sum = 0;
            Write("Input a number to check if it is perfect or not: ");
            number = ToInt32(ReadLine());
            WriteLine();
            while (number <= 0)
            {
                Write("The number should be positive. Please try again: ");
                number = ToInt32(ReadLine());
                WriteLine();
            }
            Write("The positive divisors: ");
            while (divisor <= (number - 1))
            {
                if (number % divisor == 0)
                {
                    Write("{0} ", divisor);
                    sum = sum + divisor;
                }
                divisor++;
            }
            WriteLine();
            WriteLine();
            WriteLine("The sum of the divisor is: {0}", sum);
            WriteLine();
            if (sum == number)
                Write("So, the number is perfect.");
            else
                Write("So, the number is NOT perfect.");
            WriteLine(ReadLine());
        }
    }
}
