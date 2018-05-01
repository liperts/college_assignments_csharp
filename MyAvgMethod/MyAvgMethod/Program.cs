using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MyAvgMethod
{
    class Program
    {
        /* The following code Calculates the Average of Three Numbers
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #10-Program #4
         * Date: 2018-04-09 */
        static void Main(string[] args)
        {
            WriteLine("It calculates the average of three numbers.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's calculate the average of three numbers:");
            WriteLine();
            //We can use an array to keep the numbers.
            double[] numbers = new double[3];
            double average = 0;
            int count = 0;
            //The user should set the numbers while the counter is... 
            //... less than array's length. 
            for (count = 0; count < numbers.Length; count++)
            {
                Write("Please input the value of the #{0} number: ", count + 1);
                numbers[count] = ToDouble(ReadLine());
            }
            //Here, we calculate the average using the myAvg method.
            average = myAvg(numbers[0], numbers[1], numbers[2]);
            WriteLine("The average between {0}, {1} and {2} is {3}.", numbers[0],
                numbers[1], numbers[2], average);
            Write(ReadLine());
        }
        //The myAvg method needs the numbers to calculate the average of them.
        public static double myAvg(double x, double y, double z)
        {
            //Here, we sum all of three numbers. After that, the sum is divided by 3.
            double avg = (x + y + z) / (double)3;
            //We can use the 'Math.Round' method to rounds a value... 
            //... to the specified number of fractional digits.
            //The value of 'avg' must return to the main method.
            return (Math.Round(avg, 2));
        }
    }
}