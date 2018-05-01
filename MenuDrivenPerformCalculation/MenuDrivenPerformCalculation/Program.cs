using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace MenuDrivenPerformCalculation
{
    class Program
    {
        /* The following code is a Menu-Driven to Perform a Simple Calculation
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #20
         * Date: 2018-03-09 */
        static void Main(string[] args)
        {
            WriteLine("It reads the user's choice, and perform a simple calculation.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's started to perform a simple calculation:");
            WriteLine();
            int choice = 0;
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;
            do
            {
                WriteLine();
                WriteLine("Here are the options: ");
                WriteLine(" 1 - Addition");
                WriteLine(" 2 - Subtraction");
                WriteLine(" 3 - Multiplication");
                WriteLine(" 4 - Division");
                WriteLine(" 5 - Exit");
                WriteLine();
                Write("Please input your choice (1 - 5): ");
                choice = ToInt32(ReadLine());
                if (choice != 5)
                {
                    Write("Please enter the first number: ");
                    firstNumber = ToDouble(ReadLine());
                    Write("Please enter the second number: ");
                    secondNumber = ToDouble(ReadLine());
                }
                switch (choice)
                {
                    case 1:
                        {
                            result = (firstNumber + secondNumber);
                            Write("The Addition of {0} and {1} is: {2}", firstNumber, secondNumber, Round(result, 2));
                            WriteLine();
                        }
                        break;
                    case 2:
                        {
                            result = (firstNumber - secondNumber);
                            Write("The Subtraction of {0} and {1} is: {2}", firstNumber, secondNumber, Round(result, 2));
                            WriteLine();
                        }
                        break;
                    case 3:
                        {
                            result = (firstNumber * secondNumber);
                            Write("The Multiplication of {0} and {1} is: {2}", firstNumber, secondNumber, Round(result, 2));
                            WriteLine();
                        }
                        break;
                    case 4:
                        {
                            result = (firstNumber / secondNumber);
                            Write("The Division of {0} and {1} is: {2}", firstNumber, secondNumber, Round(result, 2));
                            WriteLine();
                        }
                        break;
                    case 5:
                        Write("See you next time!");
                        break;
                    default:
                        WriteLine("Out of the range! Please Please input a number between 1 and 5.");
                        break;
                }
            }
            while (choice != 5);
            ReadLine();
        }
    }
}
