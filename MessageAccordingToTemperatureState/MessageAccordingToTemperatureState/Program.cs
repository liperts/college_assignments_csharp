using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MessageAccordingToTemperatureState
{
    class Program
    {
        /* The following code is Display a Suitable Message According to Temperature State
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #11
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is display a suitable message according to temperature state");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's see a message according to temperature state:");
            double temperature = 0;
            Write("Please input the temperature (centigrade): ");
            temperature = ToDouble(ReadLine());
            if (temperature < 0)
                WriteLine("Freezing weather");
            else if (temperature >= 0 && temperature < 10)
                WriteLine("Very cold weather");
            else if (temperature >= 10 && temperature < 20)
                WriteLine("Cold weather");
            else if (temperature >= 20 & temperature < 30)
                WriteLine("Normal in temp");
            else if (temperature >= 30 && temperature < 40)
                WriteLine("It is hot");
            else 
                WriteLine("It is very hot");
            ReadLine();
        }
    }
}
