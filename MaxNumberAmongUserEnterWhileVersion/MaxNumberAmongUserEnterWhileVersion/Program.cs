using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MaxNumberAmongUserEnterWhileVersion
{
    class Program
    {
        /* The following code is Find Max Number Among the User Enter - While Version
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #3
         * Date: 2018-03-27 */
        static void Main(string[] args)
        {
            WriteLine("It finds a max number among the user enter - while version.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's find a max number among the user enter - while version:");
            WriteLine();
            //We need the variable 'number' (user's number)...
            double number;
            //... 'count' to show a message when the first number is '-1'...
            int count = 0;
            //... and 'max' to compare with 'number'.
            double max = 0;
            Write("Please input a number (-1 to exit): ");
            number = ToDouble(ReadLine());
            //While the 'number' is different than '-1' we need to repeat the loop.
            while (number != -1)
            {
                //Just to know that the user input at least one number,...
                //... we increase the value of 'count'.
                ++count;
                //If 'number' is bigger than 'max'...
                if (number >= max)
                {
                    //... set 'max' with the value of 'number'.
                    max = number;
                }
                Write("Please input a number (-1 to exit): ");
                number = ToDouble(ReadLine());
            }
            //If the user insert '-1' ('count' is equal to '0') in the first time,
            //... we need to inform that he/she needs to try again.
            if (count == 0)
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
