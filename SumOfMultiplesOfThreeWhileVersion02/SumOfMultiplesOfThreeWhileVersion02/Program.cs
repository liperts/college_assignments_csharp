using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace SumOfMultiplesOfThreeWhileVersion02
{
    class Program
    {
        /* The following code is The Sum of Multiples of Three - While Version 02
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #9
         * Date: 2018-03-31 */
        static void Main(string[] args)
        {
            WriteLine("It shows the sum of multiples of three - while version 02.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show the sum of multiples of three - while version 02:");
            WriteLine();
            //The first number that we need to check is 1000. So, set 1000 as...
            //... the value of 'number'
            int number = 1000;
            //We need to set 1 (or something different than 0) to 'remainder'...
            //... for start the loop. 
            int remainder = 1;
            int sum = 0;
            Write("The sum of all the multiples of 3 between 1000 and 2000 are: ");
            //Do the following code while 'remainder' is different than 0.
            while (remainder != 0)
            {
                //If the remainder of 'number/3' is 0, this number is a multiple of 3.
                remainder = number % 3;
                //In this case, print the "number + " to show a big sum of all...
                //... multiples of 3 between 1000 and 2000.
                if (remainder == 0)
                {
                    //Print the number and '+' to indicate that is a sum.
                    Write("{0} + ", number);
                    //Here we need to sum the number and the last value of 'sum'.
                    sum = sum + number;
                    //We do not need to increment 'number' in that case, so...
                    //we can use the 'break' keyword to skip the follow increment.
                    break;
                }
                //We need to increment the value of 'number' to make a test...
                //... for the next number.
                ++number;
            }
            //The next multiple of 3 is always 'first multiple + 3'. So, we can...
            //... do a new loop to print those numbers. This way the code is faster...
            //... than if we test every number in the range (as a first version I did).
            while ((number + 3) <= 2000)
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
            WriteLine(ReadLine());
        }
    }
}
