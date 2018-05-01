using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace PascalPyramidForNRows
{
    class Program
    {
        /* The following code is to Display the Pascal Pyramid for N Rows
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #11
         * Date: 2018-03-23 */
        static void Main(string[] args)
        {
            WriteLine("It displays the Pascal pyramid for n rows");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the Pascal pyramid for n rows:");
            WriteLine();
            int number = 0;
            int row = 0;
            int column = 0;
            int count = 0;
            int pascal = 0;
            Write("Please input the number of rows: ");
            number = ToInt32(ReadLine());
            WriteLine();
            while (number <= 0)
            {
                Write("The number of rows should be positive. Please try again: ");
                number = ToInt32(ReadLine());
                WriteLine();
            }
            for (row = 1; row <= number; row++)
            {
                for (int space = (number - row); space >= 1; space--)
                    Write(" ");
                for (column = 1; column < row; column++)
                {
                    Write("{0} ", column);
                }
                for (column = 1; column == row; column++)
                {
                    Write("1 ");
                }
                count = --row;
                for (column = ++row; count >= 1; count--)
                {
                    Write("{0} ", count);
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}
