using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CelsiusToFahrenheitDoWhileVersion
{
    class Program
    {
        /* The following code Shows a Table of Celsius to Fahrenheit - Do While Version
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #6
         * Date: 2018-03-27 */
        static void Main(string[] args)
        {
            WriteLine("It shows a table of Celsius to Fahrenheit - do while version.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("This is the table of Celsius to Fahrenheit - do while version:");
            WriteLine();
            double fahrenheit = 0;
            double celsius = 0;
            //This is the head of the table. We can use '\t' for a horizontal tab.
            WriteLine("Celsius\t|\tFahrenheit");
            //We need to print a table from 0 Celsius to 100 Celsius...
            //... then, the loop needs to start and finish using this range.
            do
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                WriteLine("{0}\t|\t{1}", celsius, fahrenheit);
                celsius = celsius + 10;
            }
            while (celsius >= 0 && celsius <= 100);
            Write(ReadLine());
        }
    }
}
