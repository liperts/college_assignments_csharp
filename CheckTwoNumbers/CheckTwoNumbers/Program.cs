using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckTwoNumbers
{
    class Program
    {
        /* The following code is Checking If Two Integers are Equal or Not
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #01
         * Date: 2018-03-06 */
        static void Main(string[] args)
        {
            WriteLine("The program is Checking If Two Integers are Equal or Not");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check if the two integers numbers are equal:");
            int firstNumber = 0;
            int secondNumber = 0;
            Write("Please set the value for the first number: ");
            firstNumber = ToInt32(ReadLine());
            Write("Please set the value for the second number: ");
            secondNumber = ToInt32(ReadLine());
            if (firstNumber == secondNumber)
                Write("The two numbers are equal.");
            else if (firstNumber < secondNumber)
                Write("The fist number ({0}) is smaller than second number ({1}).", firstNumber, secondNumber);
            else
                Write("The fist number ({0}) is bigger than second number ({1}).", firstNumber, secondNumber);
                ReadLine();
        }
    }
}
