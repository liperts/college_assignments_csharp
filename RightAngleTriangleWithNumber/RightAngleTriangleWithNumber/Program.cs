using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace RightAngleTriangleWithNumber
{
    class Program
    {
        /* The following code is Display the Pattern Right Angle Triangle With a Number
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Problem Statement #27
         * Date: 2018-03-14 */
        static void Main(string[] args)
        {
            WriteLine("It display the pattern right angle triangle with a number.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display a right angle triangle with a number:");
            WriteLine();
            int number = 0;
            Write("Please input a number of rows: ");
            number = ToInt32(ReadLine());
            while (number <= 0)
            {
                Write("Number of rows should be positive. Please try again: ");
                number = ToInt32(ReadLine());
                WriteLine();
            }
            for (int row = 1; row <= number; row++)
            {
                for (int colum = 1; colum <= row; colum++)
                {
                    Write("{0} ", colum);
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}