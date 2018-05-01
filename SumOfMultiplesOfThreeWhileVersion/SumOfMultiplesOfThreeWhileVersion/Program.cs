using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace SumOfMultiplesOfThreeWhileVersion
{
    class Program
    {
        /* The following code is The Sum of Multiples of Three - While Version
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #9
         * Date: 2018-03-28 */
        static void Main(string[] args)
        {
            WriteLine("It shows the sum of multiples of three - while version.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show the sum of multiples of three - while version:");
            WriteLine();
            //The first number that we need to check is 1000. So, set 1000 as...
            //... the value of 'number'
            int number = 1000;
            int remainder = 0;
            int sum = 0;
            Write("The sum of all the multiples of 3 between 1000 and 2000 are: ");
            //Do the following code while 'number' is a number between 1000 and 2000.
            while (number >= 1000 && number <= 2000)
            {
                //If the remainder of 'number/3' is 0, this number is a multiple of 3.
                remainder = number % 3;
                if (remainder == 0)
                {
                    //Then, print the number and '+' to indicate that is a sum.
                    Write("{0} + ", number);
                    //Here we need to sum the number and the last value of 'sum'.
                    sum = sum + number;
                }
                //We need to increment the value of 'number' to keep the loop working.
                ++number;
            }
            WriteLine();
            WriteLine();
            //Here, we print the value of 'sum'.
            Write("The value of that sum is: {0}", sum);
            WriteLine(ReadLine());
        }
    }
}
