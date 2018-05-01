using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace SumOfTheGivenSeries
{
    class Program
    {
        /* The following code is Display the Sum of the Series [ 1+x+x^2/2!+x^3/3!+... ]
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #6
         * Date: 2018-03-18 */
        static void Main(string[] args)
        {
            WriteLine("It display the sum of the series [ 1+x+x^2/2!+x^3/3!+ ...].");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the sum of the series [ 1+x+x^2/2!+x^3/3!+ ...]:");
            WriteLine();
            double x = 0;
            double number = 0;
            double count = 0;
            double power = 0;
            double countFactorial = 0;
            double nFactorial = 0;
            double sum = 0;
            Write("Input the value of x: ");
            x = ToDouble(ReadLine());
            WriteLine();
            Write("Input number of terms: ");
            number = ToDouble(ReadLine());
            WriteLine();
            while (number <= 0)
            {
                Write("The number of terms should be positive. Please try again: ");
                number = ToDouble(ReadLine());
                WriteLine();
            }
            for (count = 2; count <= (number - 1); count++)
            {
                power = (Pow(x, count));
                nFactorial = count;
                for (countFactorial = count; (countFactorial - 1) > 1; countFactorial--)
                {
                    nFactorial = nFactorial * (countFactorial - 1);
                }
                sum = sum + (power / nFactorial);
            }
            sum = sum + 1 + x;
            Write("The sum is: {0:0.000000}", sum);
            WriteLine();
            Write("Number of terms = {0}", number);
            WriteLine();
            Write("The value of x = {0:0.000000}", x);
            WriteLine(ReadLine());
        }
    }
}