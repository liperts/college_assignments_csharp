using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace SmallerMidBiggerNumberOfThree
{
    class Program
    {
        /* The following code is Finds the Smaller, the Mid, and the Bigger Number of 3
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #08
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is Finds the Smaller, the Mid, and the Bigger Number of 3");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's find the smaller, the mid, and the bigger number of 3:");
            double firstNumber = 0;
            double secondNumber = 0;
            double thirdNumber = 0;
            double bigger = 0;
            double biggest = 0;
            double smaller = 0;
            double smallest = 0;
            double mid = 0;
            Write("Please enter the value of the first number: ");
            firstNumber = ToDouble(ReadLine());
            Write("Please enter the value of the second number: ");
            secondNumber = ToDouble(ReadLine());
            Write("Please enter the value of the third number: ");
            thirdNumber = ToDouble(ReadLine());
            WriteLine();
            if (firstNumber > secondNumber)
            {
                bigger = firstNumber;
                smaller = secondNumber;
            }
            else
            {
                bigger = secondNumber;
                smaller = firstNumber;
            }
            if (thirdNumber > bigger)
            {
                biggest = thirdNumber;
            }
            else
            {
                biggest = bigger;
            }
            if (thirdNumber < smaller)
            {
                smallest = thirdNumber;
            }
            else
            {
                smallest = smaller;
            }
            mid = firstNumber + secondNumber + thirdNumber - biggest - smallest;
            WriteLine("The biggest is {0}", biggest);
            WriteLine("The mid-term is {0}", mid);
            WriteLine("The smallest is {0}", smallest);
            WriteLine();
            WriteLine("The ascending order is {0}, {1}, and {2}", smallest, mid, biggest);
            ReadLine();
        }
    }
}
