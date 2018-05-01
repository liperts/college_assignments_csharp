using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace PyramidWithAnAsterisk
{
    class Program
    {
        /* The following code is Display a Pyramid with an Asterisk
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Problem Statement #29
         * Date: 2018-03-10 */
        static void Main(string[] args)
        {
            WriteLine("It display a pyramid with an asterisk.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display a pyramid with an asterisk:");
            WriteLine();
            int number = 0;
            Write("Please input the number of rows: ");
            number = ToInt32(ReadLine());
            WriteLine();
            for (int row = 1; row <= number; row++)
            {
                for (int space = (number - row); space >= 1; space--)
                    Write(" ");
                for (int colum = 1; colum <= row; colum++)
                {
                    Write("* ");
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}