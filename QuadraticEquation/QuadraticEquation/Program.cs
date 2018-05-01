using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuadraticEquation
{
    class Program
    {
        /*The following code is Calculating Quadratic Equation
         * COURSE COMP100
         * Written by: Group #02
         * Assignment #04-Quadratic Equation
         * Date: 2018-02-23 */
        static void Main(string[] args)
        {
            WriteLine("The program is Calculating Quadratic Equation");
            WriteLine("Written by: Group 02");
            double a = 0;
            double b = 0;
            double c = 0;
            double x1 = -1;
            double x2;
            while (x1 < 0)
            {
                Write("Please set the value for 'a': ");
                a = Convert.ToDouble(ReadLine());
                while (a == 0)
                {
                    Write("Please set the value for 'a' different of 0: ");
                    a = Convert.ToDouble(ReadLine());
                }
                Write("Please set the value for 'b': ");
                b = Convert.ToDouble(ReadLine());
                Write("Please set the value for 'c': ");
                c = Convert.ToDouble(ReadLine());
                x1 = Math.Pow(b, 2) - 4 * a * c;
                if (x1 < 0)
                    WriteLine("Error! Please try again.");
            }
            x2 = (-b - Math.Sqrt(x1)) / 2 * a;
            x1 = (-b + Math.Sqrt(x1)) / 2 * a;
            Write("The values of Quadratic Equation are: {0} and {1}.", x1, x2);
            ReadLine();
        }
    }
}
