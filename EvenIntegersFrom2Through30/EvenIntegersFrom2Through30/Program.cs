using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace EvenIntegersFrom2Through30
{
    class Program
    {
        /* The following code is Display the Even Integers from 2 Through 30
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #07-Program #1
         * Date: 2018-03-19 */
        static void Main(string[] args)
        {
            WriteLine("It display the even integers from 2 through 30.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the even integers from 2 through 30:");
            WriteLine();
            //The even numbers should be between 2 and 30.
            //Thus, the first even number is 2.
            int even = 2;
            //Just to practice, let's use 'count' to count the total number...
            //of even numbers in that range.
            int count = 0;
            //The maximum limit of the range is 30 (a even number).
            //So, we need to include 30 in the loop.
            while (even <= 30)
            {
                //To count the number of terms, we need to increment count.
                ++count;
                //This way we can see the number of the term and the relative even.
                WriteLine("Even number #{0}: {1};", count, even);
                //The next even is always plus 2. So, we need to increment this way.
                even = even + 2;
            }
            WriteLine();
            //Here we can see the final value of count one more time.
            Write("The number of even numbers between 2 and 30 is: {0}", count);
            //The following code is for when you press F5 and 
            //want to see the result before it is closed
            WriteLine(ReadLine());
        }
    }
}
