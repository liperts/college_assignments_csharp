using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MyMaxMethod
{
    class Program
    {
        /* The following code Find the Maximum Value of Two Numbers
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #10-Program #3
         * Date: 2018-04-09 */
        static void Main(string[] args)
        {
            WriteLine("It finds the maximum value of two numbers.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's see which number is bigger than other one:");
            WriteLine();
            //We can use an array to keep the numbers.
            double[] numbers = new double[2];
            double max = 0;
            int count = 0;
            //The user should set the numbers while the counter is... 
            //... less than array's length. 
            for (count = 0; count < numbers.Length; count++)
            {
                Write("Please input the value of the #{0} number: ", count + 1);
                numbers[count] = ToDouble(ReadLine());
            }
            //Here, we find the maximun value using the myMax method.
            max = myMax(numbers[0], numbers[1]);
            WriteLine("The maximum value between {0} and {1} is {2}.", numbers[0],
                numbers[1], max);
            Write(ReadLine());
        }
        //The myMax method needs two numbers to check which one is the largest.
        public static double myMax(double x, double y)
        {
            double bigger = 0;
            //If the first one is bigger than the second one... 
            if (x > y)
            {
                //... set the first number as 'bigger'.
                bigger = x;
            }
            //If not... 
            else 
            {
                //... set the second one as a 'bigger'.
                bigger = y;
            }
            //The value of 'bigger' must return to the main method.
            return (bigger);
        }
    }
}