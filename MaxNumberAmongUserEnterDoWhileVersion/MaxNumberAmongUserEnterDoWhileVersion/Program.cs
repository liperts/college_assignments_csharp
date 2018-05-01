using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MaxNumberAmongUserEnterDoWhileVersion
{
    class Program
    {
        /* The following code is Find Max Number Among the User Enter - Do While Version
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #4
         * Date: 2018-03-27 */
        static void Main(string[] args)
        {
            WriteLine("It finds a max number among the user enter - do while version.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's find max number among the user enter - do while version:");
            WriteLine();
            //We need the variable 'number' (user's number)...
            double number;
            //... 'count' to show a message when the first number is '-1'...
            int count = 0;
            //... and 'max' to compare with 'number'.
            double max = 0;
            //While the 'number' is different than '-1' we need to repeat the loop.
            do
            {
                Write("Please input a number (-1 to exit): ");
                number = ToDouble(ReadLine());
                //Just to know that the user input at least one number,...
                //... we increase the value of 'count'.
                ++count;
                //If 'number' is bigger than 'max'...
                if (number >= max)
                {
                    //... set 'max' with the value of 'number'.
                    max = number;
                }
            }
            while (number != -1);
            //If the user insert '-1' ('count' is equal to '0') in the first time,
            //... we need to inform that he/she needs to try again.
            if (count == 1)
            {
                Write("You need to set at least one number. Please try again.");
            }
            //Otherwise, we can print the maximum value that user inserted.
            else
            {
                Write("The maximum number among the numbers the user enter is {0}.", +
                    max);
            }
            WriteLine(ReadLine());
        }
    }
}
