using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace LabPractice02_Problem03
{
    class Program
    {
        /* The following code Calculates the Factorial of a Number
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Lab Practice #02 - Problem #03
         * Date: 2018-04-21 */
        static void Main(string[] args)
        {
            WriteLine("It calculates the factorial of a number.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's calculate the factorial of a number:");
            WriteLine();
            int n = 0;
            int fact = 0;
            do
            {
                Write("Please input the number (number >= 0): ", n);
                n = ToInt32(ReadLine());
                if (n < 0)
                {
                    Write("The number should be more than or equal to 0. ");
                    WriteLine("Please try again.");
                    WriteLine();
                }
            }
            while (n < 0);
            fact = myFact(n);
            WriteLine("The factorial of {0} is {1}.", n, fact);
            Write(ReadLine());
        }
        public static int myFact(int number)
        {
            int factorial = 1;
            if (number == 0)
            {
                factorial = 1;
            }
            else
                for (int count = number; count > 1; count--)
                {
                    factorial *= count;
                }
            return (factorial);
        }
    }
}
