using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MyFactMethod
{
    class Program
    {
        /* The following code Calculates the Factorial of a Number
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #10-Program #5
         * Date: 2018-04-10 */
        static void Main(string[] args)
        {
            WriteLine("It calculates the factorial of a number.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's calculate the factorial of a number:");
            WriteLine();
            int n = 0;
            int fact = 0;
            //We need a number more than or equal to 0 to calculate... 
            //... the factorial of a number. So, we can use a loop... 
            //... to verify the number that user set.
            do
            {
                Write("Please input the number (number >= 0): ", n);
                n = ToInt32(ReadLine());
                if (n < 0)
                {
                    Write("The number should be more than or equal to 0. ");
                    WriteLine("Please try again.");
                    WriteLine();
                }
            }
            //While the number is less than 0, the user needs to try again.
            while (n < 0);
            //If not, we can calculate the factorial using myFact method.
            fact = myFact(n);
            WriteLine("The factorial of {0} is {1}.", n, fact);
            Write(ReadLine());
        }
        //Here, we have the method to calculate the factorial of any possible number.
        public static int myFact(int number)
        {
            int factorial = 1;
            //The factorial of 0 is 1...
            if (number == 0)
            {
                factorial = 1;
            }
            //If the number is more than 0, we need to calculate.
            else
                //We can use a counter in decrease mode to calculate the factorial.
                for (int count = number; count > 1; count--)
                {
                    factorial *= count;
                }
            //We need to return the value of factorial to use in the main method.
            return (factorial);
        }
    }
}
