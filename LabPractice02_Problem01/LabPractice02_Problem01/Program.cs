using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace LabPractice02_Problem01
{
    class Program
    {
        /* The following code is to Read any Digit, and Display as a Word
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Lab Practice #02 - Problem #01
         * Date: 2018-04-21 */
        static void Main(string[] args)
        {
            WriteLine("The program reads any digit, and display as a word.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's input any digit, and see it as a word:");
            int digit = 0;
            Write("Please input any digit: ");
            digit = ToInt32(ReadLine());
            switch (digit)
            {
                case 0:
                    WriteLine("Zero");
                    break;
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    break;
                case 3:
                    WriteLine("Three");
                    break;
                case 4:
                    WriteLine("Four");
                    break;
                case 5:
                    WriteLine("Five");
                    break;
                case 6:
                    WriteLine("Six");
                    break;
                case 7:
                    WriteLine("Seven");
                    break;
                case 8:
                    WriteLine("Eight");
                    break;
                case 9:
                    WriteLine("Nine");
                    break;
                default:
                    WriteLine("Out of the range! Please input a number between 0 and 9 (a digit)");
                    break;
            }
            ReadLine();
        }
    }
}