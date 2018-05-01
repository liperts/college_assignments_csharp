using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckYearLeap
{
    class Program
    {
        /* The following code is Checking If the Year is Leap or Not
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #04
         * Date: 2018-03-06 */
        static void Main(string[] args)
        {
            WriteLine("The program is Checking If the Year is Leap or Not");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check if the year is leap or not:");
            int year = 0;
            int numberDays = 0;
            Write("Please set the year: ");
            year = ToInt32(ReadLine());
            Write("Please set the number of days for {0}: ", year);
            numberDays = ToInt32(ReadLine());
            switch (numberDays)
            {
                case 366:
                    WriteLine("The year {0} is leap.", year);
                    break;
                case 365:
                    WriteLine("The year {0} is not leap.", year);
                    break;
                default:
                    WriteLine("Out of the range! The number of days should be 365 or 366.");
                    break;
            }
            /*Other possibility...
            if (numberDays == 366)
                Write("The year {0} is leap.", year);
            else if (numberDays == 365)
                Write("The year {0} is not leap.", year);
            else 
                Write("The number of days should be 365 or 366. Please try again.")*/
            ReadLine();
        }
    }
}
