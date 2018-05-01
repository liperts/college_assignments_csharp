using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace PrintTheFloydsTriangle
{
    class Program
    {
        /* The following code is Print the Floyd's Triangle
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #5
         * Date: 2018-03-15 */
        static void Main(string[] args)
        {
            WriteLine("It prints the Floyd's triangle.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's print the Floyd's triangle:");
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
                    if (colum == row)
                        Write("1");
                    else if ((row - colum) % 2 == 0)
                        Write("1");
                    else if ((row - colum) % 2 == 1)
                        Write ("0");
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}