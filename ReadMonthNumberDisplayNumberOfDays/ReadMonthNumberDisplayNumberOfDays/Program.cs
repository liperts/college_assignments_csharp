using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ReadMonthNumberDisplayNumberOfDays
{
    class Program
    {
        /* The following code is to Read any Month Number and Display Number of Days
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #18
         * Date: 2018-03-09 */
        static void Main(string[] args)
        {
            WriteLine("The program reads any month number, and display number of days.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's input any month number, and see the number of days:");
            int monthNumber = 0;
            Write("Please input any month number: ");
            monthNumber = ToInt32(ReadLine());
            switch (monthNumber)
            {
                case 1:
                    WriteLine("Month have 31 days.");
                    break;
                case 2:
                    WriteLine("Month have 28 or 29 days.");
                    break;
                case 3:
                    WriteLine("Month have 31 days.");
                    break;
                case 4:
                    WriteLine("Month have 30 days.");
                    break;
                case 5:
                    WriteLine("Month have 31 days.");
                    break;
                case 6:
                    WriteLine("Month have 30 days.");
                    break;
                case 7:
                    WriteLine("Month have 31 days.");
                    break;
                case 8:
                    WriteLine("Month have 31 days.");
                    break;
                case 9:
                    WriteLine("Month have 30 days.");
                    break;
                case 10:
                    WriteLine("Month have 31 days.");
                    break;
                case 11:
                    WriteLine("Month have 30 days.");
                    break;
                case 12:
                    WriteLine("Month have 31 days.");
                    break;
                default:
                    WriteLine("Out of the range! Please input a number between 1 and 12.");
                    break;
            }
            ReadLine();
        }
    }
}