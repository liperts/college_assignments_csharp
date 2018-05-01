using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Toronto_sWeather
{
    class Program
    {
        /* The following code Does Some Calculations of Toronto's Weather
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #09-Program #1
         * Date: 2018-04-04 */
        static void Main(string[] args)
        {
            WriteLine("It does some calculations of Toronto's weather.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's do some calculations of Toronto's weather:");
            WriteLine();
            //We need to use the new concept, array:
            double[] temperature = new double[] { -1, 0, 5, 4, 3, -2, 7 };
            //To solve the calculations we need to use a counter into the for loop...
            //... and other variables to solve the calculations.
            int count;
            double sum = 0;
            double max = 0;
            double min = 0;
            double avg = 0;
            //The loop needs to repeat until the array's lenght.
            for (count = 0; count < temperature.Length; count++)
            {
                //The following code is to calculate the sum of temperatures.
                sum = sum + temperature[count];
                //Here, we find the maximum temperature and set into 'max'.
                if (temperature[count] > max)
                {
                    max = temperature[count];
                }
                //Otherwise, we find the minimum temperature and set into 'min'.
                else
                {
                    min = temperature[count];
                }
            }
            //Print the maximum and the minimum temperature.
            WriteLine("The maximum temperature is {0}.", max);
            WriteLine("The minimum temperature is {0}.", min);
            //Here we calculate the average of the temperature.
            avg = sum / temperature.Length;
            //Print the average of the temperatures. We can use the 'Round' method to...
            //... show a value to the specified number of fractional digits.
            Write("The average of the temperature is: {0}", Math.Round(avg, 2));
            WriteLine(ReadLine());
        }
    }
}
