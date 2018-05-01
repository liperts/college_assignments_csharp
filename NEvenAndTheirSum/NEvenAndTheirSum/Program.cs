using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace NEvenAndTheirSum
{
    class Program
    {
        /* The following code is Display the n Terms of Even and Their Sum
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #06-Bonus Question #2
         * Date: 2018-03-15 */
        static void Main(string[] args)
        {
            WriteLine("It display the n terms of even natural numbers and their sum.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's display the n terms of even natural numbers and their sum:");
            WriteLine();
            int number = 0;
            int sum = 0;
            Write("Input number of terms: ");
            number = ToInt32(ReadLine());
            WriteLine();
            while (number <= 0)
            {
                Write("The number of terms should be positive. Please try again: ");
                number = ToInt32(ReadLine());
                WriteLine();
            }
            Write("The even numbers are: ");
            for (int n = 2; n <= (number * 2); n = (n + 2))
            {
                Write("{0} ", n);
                sum = sum + n;
            }
            WriteLine();
            Write("The Sum of even Natural Number up to {0} terms is: {1}", number, sum);
            WriteLine();
            ReadLine();
        }
    }
}
