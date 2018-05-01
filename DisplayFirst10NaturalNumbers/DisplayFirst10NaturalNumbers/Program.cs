using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayFirst10NaturalNumbers
{
    class Program
    {
        /* The following code is Display the First 10 Natural Numbers
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #21
         * Date: 2018-03-09 */
        static void Main(string[] args)
        {
            WriteLine("It display the first 10 natural numbers.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show the first 10 natural numbers:");
            WriteLine();
            int number = 0;
            for (number = 1; number <= 10; number++)
                Write("{0} ", number);
            ReadLine();
        }
    }
}