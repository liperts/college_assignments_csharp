using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace CubeOfNumberOfTerms
{
    class Program
    {
        /* The following code is Display the Cube of the Number up to Given an Integer
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #24
         * Date: 2018-03-10 */
        static void Main(string[] args)
        {
            WriteLine("It display the cube of the number up to given an integer.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the cube of the number up to given an integer:");
            WriteLine();
            double number = 0;
            double cube = 0;
            Write("Please input a number: ");
            number = ToInt32(ReadLine());
            for (double n = 1; n <= number; n++)
            {
                cube = Pow(n, 3);
                WriteLine("Number is: {0} and cube of the {1} is: {2}", n, n, cube);
            }
            ReadLine();
        }
    }
}
