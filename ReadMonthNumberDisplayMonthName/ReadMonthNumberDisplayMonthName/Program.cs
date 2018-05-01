using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ReadMonthNumberDisplayMonthName
{
    class Program
    {
        /* The following code is to Read any Month Number and Display Month Name
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #17
         * Date: 2018-03-09 */
        static void Main(string[] args)
        {
            WriteLine("The program reads any month number, and display month name.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's input any month number, and see the month name:");
            int monthNumber = 0;
            Write("Please input any month number: ");
            monthNumber = ToInt32(ReadLine());
            switch (monthNumber)
            {
                case 1:
                    WriteLine("January");
                    break;
                case 2:
                    WriteLine("February");
                    break;
                case 3:
                    WriteLine("March");
                    break;
                case 4:
                    WriteLine("April");
                    break;
                case 5:
                    WriteLine("May");
                    break;
                case 6:
                    WriteLine("June");
                    break;
                case 7:
                    WriteLine("July");
                    break;
                case 8:
                    WriteLine("August");
                    break;
                case 9:
                    WriteLine("September");
                    break;
                case 10:
                    WriteLine("October");
                    break;
                case 11:
                    WriteLine("November");
                    break;
                case 12:
                    WriteLine("December");
                    break;
                default:
                    WriteLine("Out of the range! Please input a number between 1 and 12.");
                    break;
            }
            ReadLine();
        }
    }
}