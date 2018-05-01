using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace SumOfMultiplesOfThreeDoWhileVersion02
{
    class Program
    {
        /* The following code is The Sum of Multiples of Three - Do While Version 02
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #10
         * Date: 2018-03-31 */
        static void Main(string[] args)
        {
            WriteLine("It shows the sum of multiples of three - do while version 02.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show the sum of multiples of three - do while version 2:");
            WriteLine();
            //The first number that we need to check is 1000. So, set 1000 as...
            //... the value of 'number'
            int number = 1000;
            int remainder = 0;
            int sum = 0;
            Write("The sum of all the multiples of 3 between 1000 and 2000 are: ");
            //Do the following code while...
            do
            {
                //If the remainder of 'number/3' is 0, this number is a multiple of 3.
                remainder = number % 3;
                if (remainder == 0)
                {
                    //Then, print the number and '+' to indicate that is a sum.
                    Write("{0} + ", number);
                    //Here we need to sum the number and the last value of 'sum'.
                    sum = sum + number;
                    //We do not need to increment 'number' in that case, so...
                    //we can use the 'break' keyword to skip the follow increment.
                    break;
                }
                //We need to increment the value of 'number' to keep the loop working.
                ++number;
            }
            //... 'number' is a number between 1000 and 2000.
            while (remainder != 0);
            do
            {
                number = number + 3;
                if ((number + 3) <= 2000)
                {
                    Write("{0} + ", number);
                    sum = sum + number;
                }
                else
                {
                    //If 'number + 3' is more than 2000, this is the last multiple...
                    //... of 3 in on that range. So, print 'number = sum' and...
                    //... finish the program.
                    sum = sum + number;
                    //Here, we print the value of 'number' and the sum of all...
                    //... multiples of 3 on that range.
                    Write("{0} = {1}", number, sum);
                }
            }
            while ((number + 3) <= 2000);
            WriteLine(ReadLine());
        }
    }
}
