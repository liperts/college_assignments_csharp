using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LabPractice02_Problem02
{
    class Program
    {
        /* The following code Does Some Calculations of Toronto's Weather
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Lab Practice #02 - Problem #02
         * Date: 2018-04-21 */
        static void Main(string[] args)
        {
            WriteLine("It does some calculations of Toronto's weather.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's do some calculations of Toronto's weather:");
            WriteLine();
            double[] temperature = new double[] { -1, 0, 5, 4, 3, -2, 7 };
            int count;
            double sum = 0;
            double max = 0;
            double min = 0;
            double avg = 0;
            for (count = 0; count < temperature.Length; count++)
            {
                sum = sum + temperature[count];
                if (temperature[count] > max)
                {
                    max = temperature[count];
                }
                if (temperature[count] <= min)
                {
                    min = temperature[count];
                }
            }
            WriteLine("The maximum temperature is {0}.", max);
            WriteLine("The minimum temperature is {0}.", min);
            avg = sum / temperature.Length;
            Write("The average of the temperature is: {0}", Math.Round(avg, 2));
            WriteLine(ReadLine());
        }
    }
}