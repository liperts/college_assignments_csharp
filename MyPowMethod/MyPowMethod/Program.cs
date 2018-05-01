using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MyPowMethod
{
    class Program
    {
        /* The following code Calculates the Base to the Power of Exponent
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #10-Program #2
         * Date: 2018-04-09 */
        static void Main(string[] args)
        {
            WriteLine("It calculates the base to the power of exponent.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's calculate the base to the power of exponent!");
            WriteLine();
            double basePow = 0;
            double exponent = 0;
            double pow = 0;
            //The user should set the value of the base and the exponent.
            Write("Please input the value of the base: ", basePow);
            basePow = ToInt32(ReadLine());
            Write("Please input the value of the exponent: ", exponent);
            exponent = ToInt32(ReadLine());
            //Here, we calculate the value of the 'power' using the myPow method.
            pow = myPow(basePow, exponent);
            WriteLine("The result of {0} to the power of {1} is {2}.", basePow,
                exponent, pow);
            Write(ReadLine());
        }
        //The myPow method needs two numbers to calculate the 'power'.
        public static double myPow(double x, double y)
        {
            double result = 1;
            //Every time the exponent is 0, 'power' is 1.
            if (y == 0)
            {
                result = 1;
            }
            //Every time the base is 0, 'power' also is 0.
            if (x == 0)
            {
                result = 0;
            }
            //Otherwise, we can calculate the base to the power of the exponent.
            else 
                //We need to repeat 'x*x' until counter is less than or equal to 'y'... 
                for (int count = 1; count <= y; count++)
                {
                    //... and keep the result of the multiplication in 'result'.
                    result *= x;
                }
            //We need to return the value of result ('power') to use in the main method.
            return (result);
        }
    }
}
