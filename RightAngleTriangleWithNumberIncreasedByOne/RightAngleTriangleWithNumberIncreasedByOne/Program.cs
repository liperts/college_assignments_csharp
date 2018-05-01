using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace RightAngleTriangleWithNumberIncreasedByOne
{
    class Program
    {
        /* The following code is Display a Right Triangle With a Number Increased by 1
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Problem Statement #28
         * Date: 2018-03-14 */
        static void Main(string[] args)
        {
            WriteLine("It display a right triangle with a number increased by 1.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display a right triangle with a number increased by 1:");
            WriteLine();
            int number = 0;
            int n = 1;
            Write("Please input a number of rows: ");
            number = ToInt32(ReadLine());
            WriteLine();
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
                    if (n < 10)
                    {
                        Write("  {0}  ", n);
                        n = n + 1;
                    }
                    else
                    {
                        Write(" {0}  ", n);
                        n = n + 1;
                    }
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}