using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CalculatingNFactorial
{
    class Program
    {
        /*The following code is Calculating N Factorial (N!)
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Student No: 300963168
         * Group No: 02
         * Assignment #03-Math Problem 03
         * Date: 2018-02-16 */
        static void Main(string[] args)
        {
            WriteLine("The program is Calculating N Factorial");
            WriteLine("Written by: Lipe Teixeira");
            string numberString;
            int numberInt, count;
            int nFactorial = 0;
            Write("Please, input a integer and positive number: ");
            //The Reza's file "Microsoft Visual C#_Ch02_PPT" 
            //shows how to convert variable
            numberString = ReadLine();
            numberInt = Convert.ToInt32(numberString);
            //If the numberInt is equal to 0, nFactorial is equal to 1
            if (numberInt == 0)
            {
                nFactorial = 1;
                Write("The value of 0! is {0}.", nFactorial);
            }
            //If the numberInt is more than 0...
            else if (numberInt > 0)
            {
                nFactorial = numberInt;
                //We need to use another variable in the loop 
                //instead of numberInt to keep the value of numberInt
                count = numberInt;
                while (count - 1 > 1)
                {
                    //Using loop to calculate the value of nFactorial
                    nFactorial = nFactorial * (count - 1);
                    //Decrement count
                    count = count - 1;
                }
                //The following line is for printing the result
                Write("The value of {0}! is {1}.", numberInt, nFactorial);
            }
            //If the numberInt is less than 0...
            else
            {
                //...is necessary to run the code again
                Write("Error! Please try again.");
            }
            //The following code is for when you press F5 and 
            //want to see the result before it is closed
            ReadLine();
        }
    }
}
