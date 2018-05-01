using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MultiplicationBy2
{
    class Program
    {
        /* The following code is Display the Multiplication by 2 (1 to 10)
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #07-Program #2
         * Date: 2018-03-19 */
        static void Main(string[] args)
        {
            WriteLine("It display the multiplication by 2 (1 to 10).");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the multiplication by 2 (1 to 10):");
            WriteLine();
            int count = 1;
            int result = 0;
            //We need to use the 'count' variable to increment...
            //the value that be multiply by 2 (until 10).
            while (count <= 10)
            {
                //Set the value of 2 times 'the value of 'count'' in 'result'.
                result = 2 * count;
                //This way we can see the value of 'count' and 
                //the result of multiplication
                WriteLine("2 * {0} = {1}", count, result);
                //Here we increment 'count'.
                ++count;
            }
            ReadLine();
        }
    }
}
