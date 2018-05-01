using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckNumberEvenOdd
{
    class Program
    {
        /* The following code is Checking If the Number is Even or Odd
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #02
         * Date: 2018-03-06 */
        static void Main(string[] args)
        {
            WriteLine("The program is Checking If the Number is Even or Odd");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check if the number is even or odd:");
            int number = 0;
            Write("Please set the value for the number: ");
            number = ToInt32(ReadLine());
            if (number % 2 == 0)
                Write("The number {0} is even.", number);
            else 
                Write("The number {0} is odd.", number);
            ReadLine();
        }
    }
}
