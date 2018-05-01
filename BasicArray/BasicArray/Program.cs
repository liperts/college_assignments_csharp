using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace BasicArray
{
    class Program
    {
        /* The following code Does Some Basic Array Things
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #10-Program #1
         * Date: 2018-04-09 */
        static void Main(string[] args)
        {
            WriteLine("It does some basic array things.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's do some basic array things:");
            WriteLine();
            //We need to use the new concept, array:
            double[] arrayOfNumbers = new double[10];
            //To solve the calculations we need to use a counter into the for loop...
            //... and other variables to solve the calculations.
            int count;
            double sum = 0;
            double max = 0;
            double min = 0;
            double avg = 0;
            //The first loop get the numbers from user...
            for (count = 0; count < arrayOfNumbers.Length; count++)
            {
                Write("Please insert the #{0} number to store in an array: ", count + 1);
                arrayOfNumbers[count] = ToDouble(ReadLine());
                //... and sum all of values inserted by user.
                sum += arrayOfNumbers[count];
            }
            //We need to set the value of the first element on array's list...
            //... as a minimum value to compare into the next loop.
            min = arrayOfNumbers[0];
            //After the user set all values we need the other loop to find...
            //... the minimum and maximum value in the array.
            for (count = 0; count < arrayOfNumbers.Length; count++)
            {
                //Here, we can get the biggest and smallest number of the array.
                if (max <= arrayOfNumbers[count])
                {
                    max = arrayOfNumbers[count];
                }
                else if (min >= arrayOfNumbers[count])
                {
                    min = arrayOfNumbers[count];
                }
            }
            ReadLine();
            //The second loop print the number that user inserted before,... 
            //... just to show the array works.
            for (count = 0; count < arrayOfNumbers.Length; count++)
            {
                WriteLine("The #{0} number that you insert was: {1}", count + 1, 
                    arrayOfNumbers[count]);
            }
            ReadLine();
            WriteLine("The maximum number among the array's elements is {0}.", max);
            WriteLine("The minimum number among the array's elements is {0}.", min);
            WriteLine("The sum of all inserted values into the array is {0}.", sum);
            //Here, we can calculate the average among all array's elements.
            avg = sum / arrayOfNumbers.Length;
            //We can use the 'Math.Round' Method to round a value to...
            //... the specified number of fractional digits.
            WriteLine("The average of all inserted values into the array is {0}.", 
                Math.Round(avg, 2));
            Write(ReadLine());
        }
    }
}
