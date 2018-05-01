using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckNumberPosNeg
{
    class Program
    {
        /* The following code is Checking If the Number is Positive or Negative
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #03
         * Date: 2018-03-06 */
        static void Main(string[] args)
        {
            WriteLine("The program is Checking If the Number is Positive or Negative");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check if the number is positive or negative:");
            double number = 0;
            Write("Please set the value for the number: ");
            number = ToDouble(ReadLine());
            if (number == 0)
                Write("The number {0} is neutral.", number);
            else if (number > 0)
                Write("The number {0} is positive.", number);
            else
                Write("The number {0} is negative.", number);
            ReadLine();

        }
    }
}
