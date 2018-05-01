using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace BiggestNumberOfThree
{
    class Program
    {
        /* The following code is Find the Largest Number of Three
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #07
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is Find the Largest Number of Three");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's find the largest number of Three:");
            double firstNumber = 0;
            double secondNumber = 0;
            double thirdNumber = 0;
            double bigger = 0;
            double biggest = 0;
            Write("Please enter the value of the first number: ");
            firstNumber = ToDouble(ReadLine());
            Write("Please enter the value of the second number: ");
            secondNumber = ToDouble(ReadLine());
            Write("Please enter the value of the third number: ");
            thirdNumber = ToDouble(ReadLine());
            WriteLine();
            if (firstNumber > secondNumber)
                bigger = firstNumber;
            else
                bigger = secondNumber;
            if (thirdNumber > bigger)
                biggest = thirdNumber;
            else
                biggest = bigger;
            WriteLine("The biggest number between {0}, {1}, and {2} is {3}", firstNumber, secondNumber, thirdNumber, biggest);
            ReadLine();
        }
    }
}
