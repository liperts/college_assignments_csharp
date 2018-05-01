using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace NHarmonicSeriesAndTheirSum
{
    class Program
    {
        /* The following code is Display the n Terms of Harmonic Series and Their Sum
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #3
         * Date: 2018-03-15 */
        static void Main(string[] args)
        {
            WriteLine("It display the n terms of harmonic series and their sum.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the n terms of harmonic series and their sum:");
            WriteLine();
            int number = 0;
            double sum = 0;
            double harmonicNumber = 0;
            Write("Input number of terms: ");
            number = ToInt32(ReadLine());
            WriteLine();
            while (number <= 0)
            {
                Write("The number of terms should be positive. Please try again: ");
                number = ToInt32(ReadLine());
                WriteLine();
            }
            Write("The numbers of that harmonic serie are: ");
            for (double n = 1; n <= number; n++)
            {
                harmonicNumber = (1 / n);
                Write("1/{0} + ", n);
                sum = sum + harmonicNumber;
            }
            WriteLine();
            Write("The Sum of Series up to {0} terms is: {1}", number, Round(sum, 2));
            WriteLine();
            ReadLine();
        }
    }
}
