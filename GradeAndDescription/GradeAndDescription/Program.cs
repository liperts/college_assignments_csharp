using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace GradeAndDescription
{
    class Program
    {
        /* The following code is to Accept a Grade and Declare the Equivalent Description
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #15
         * Date: 2018-03-08 */
        static void Main(string[] args)
        {
            WriteLine("The program accepts a grade and declares the equivalent description.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's input a grade and see the equivalent description:");
            char grade = '0';
            Write("Please input a grade: ");
            grade = ToChar(ReadLine());
            if (Char.IsLetter(grade))
            {
                if (grade == 'e' || grade == 'E')
                    WriteLine("You have chosen: Excellent");
                else if (grade == 'v' || grade == 'V')
                    WriteLine("You have chosen: Very Good");
                else if (grade == 'g' || grade == 'G')
                    WriteLine("You have chosen: Good");
                else if (grade == 'a' || grade == 'A')
                    WriteLine("You have chosen: Average");
                else if (grade == 'f' || grade == 'F')
                    WriteLine("You have chosen: Fail");
                else
                    WriteLine("This grade is not have a description. Please try again.");
            }
            else 
                WriteLine("Please input 'e' / 'E', 'v' / 'V', 'g' / 'G', 'a' / 'A' or 'f' / 'F'. Try again.");

            /*Other possibility…
            if (Char.IsLetter(grade))
            {
                switch (grade)
                {
                    case 'E':
                    case 'e':
                        WriteLine("You have chosen: Excellent");
                        break;
                    case 'V':
                    case 'v':
                        WriteLine("You have chosen: Very Good");
                        break;
                    case 'G':
                    case 'g':
                        WriteLine("You have chosen: Good");
                        break;
                    case 'A':
                    case 'a':
                        WriteLine("You have chosen: Average");
                        break;
                    case 'F':
                    case 'f':
                        WriteLine("You have chosen: Fail");
                        break;
                    default:
                        WriteLine("This grade is not have a description. Please try again.");
                        break;
                }
            }
            else
                WriteLine("Please input 'e' / 'E', 'v' / 'V', 'g' / 'G', 'a' / 'A' or 'f' / 'F'. Try again.");*/
            ReadLine();
        }
    }
}
