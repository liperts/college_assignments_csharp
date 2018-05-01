using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static System.Convert;

namespace QuadraticEquation
{
    class Program
    {
        /* The following code is Calculating Quadratic Equation
         * COURSE COMP100
         * Written by: Group #02
         * Assignment #04-Quadratic Equation
         * Date: 2018-02-24 */
        static void Main(string[] args)
        {
            WriteLine("The program is Calculating Quadratic Equation");
            WriteLine("Written by: Group 02");
            WriteLine();
            WriteLine("Let's solve the Quadratic Equation: (-b +- (sqrt(b * b) - (4 * a * c))) / 2 * a");
            double a = 0;
            double b = 0;
            double c = 0;
            double delta;
            double x;
            double x1;
            double x2;
            //First, ask the user the value of 'a'
            do
            {
                Write("Please set the value for 'a': ");
                a = ToDouble(ReadLine());
                //While 'a' is equal to '0'...
                while (a == 0)
                {
                    //please ask the user to input another number
                    //(divisor should be different of '0')
                    Write("Please set the value for 'a' different of 0: ");
                    a = ToDouble(ReadLine());
                }
                //When the user input a possible value for 'a', 
                //it means, 'a' different of '0',
                //ask he or she for 'b' and 'c'
                Write("Please set the value for 'b': ");
                b = ToDouble(ReadLine());
                Write("Please set the value for 'c': ");
                c = ToDouble(ReadLine());
                //After that, set 'delta' the value of (b*b)-(4*a*c)
                delta = Pow(b, 2) - (4 * a * c);
                //If 'delta' is negative (square root should be
                //'0' or positive), print an error message...
                if (delta < 0)
                    WriteLine("Error (imaginary number)! Please try again.");
            }
            //...and try again (input 'a', 'b', and 'c')
            while (delta < 0);
            //Otherwise, the result of equation is possible; solve it
            //If 'delta' is equal to '0'...
            if (delta == 0)
            {
                //...'x1' and 'x2' are the same
                x = (-b / (2 * a));
                Write("We have only one value of Quadratic Equation: {0}.", Round(x, 2));
            }
            else
            {
                //Else, are two values of the Quadratic Equation ('x1' and 'x2')
                x1 = (-b + Sqrt(delta)) / (2 * a);
                x2 = (-b - Sqrt(delta)) / (2 * a);
                //The following line is for printing the result
                //(using the 'round' function to set two decimals places) 
                Write("The values of Quadratic Equation are: x1 = {0} and x2 = {1}.", Round(x1, 2), Round(x2, 2));
            }
            //The following code is for when you press F5 and 
            //want to see the result before it is closed
            ReadLine();
        }
    }
}