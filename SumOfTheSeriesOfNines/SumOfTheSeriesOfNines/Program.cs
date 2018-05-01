using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace SumOfTheSeriesOfNines
{
    class Program
    {
        /* The following code is Display the Sum of the Series [ 9 + 99 + 999 + 9999 ...]
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #4
         * Date: 2018-03-16 */
        static void Main(string[] args)
        {
            WriteLine("It display the sum of the series [ 9 + 99 + 999 + 9999 ...].");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the sum of the series [ 9 + 99 + 999 + 9999 ...]:");
            WriteLine();
            double number = 0;
            double nines = 9;
            double sum = 0;
            Write("Input number of terms: ");
            number = ToDouble(ReadLine());
            WriteLine();
            while (number <= 0)
            {
                Write("The number of terms should be positive. Please try again: ");
                number = ToDouble(ReadLine());
                WriteLine();
            }
            Write("The serie of nines is: 9 ");
            for (double n = 1; n <= (number - 1); n++)
            {
                nines = nines + (9 * Pow(10, n));
                Write("{0} ", nines);
                sum = sum + nines;
            }
            sum = sum + 9;
            WriteLine();
            WriteLine();
            Write("The sum of the series = {0}", sum);
            WriteLine();
            ReadLine();
        }
    }
}