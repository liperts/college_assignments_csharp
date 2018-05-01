using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace WhichQuadrantXY
{
    class Program
    {
        /* The following code is Determine in Which Quadrant the Coordinate Point (x, y) Lies
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #09
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is Determine in Which Quadrant the Coordinate Point (x, y) Lies");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's determine in which quadrant the coordinate point (x, y) lies:");
            int x = 0;
            int y = 0;
            Write("Please set the value for 'x' coordinate (different of 0): ");
            x = ToInt32(ReadLine());
            while (x == 0)
            {
                Write("You can not set 0 as the value of 'x'. Please try again: ");
                x = ToInt32(ReadLine());
            }
            Write("Please set the value for 'y' coordinate (different of 0): ");
            y = ToInt32(ReadLine());
            while (y == 0)
            {
                Write("You can not set 0 as the value of 'x'. Please try again: ");
                y = ToInt32(ReadLine());
            }
            if (x > 0 && y > 0)
                WriteLine("The coordinate point ({0}, {1}) lies in the First quadrant.", x, y);
            else if (x < 0 && y > 0)
                WriteLine("The coordinate point ({0}, {1}) lies in the Second quadrant.", x, y);
            else if (x < 0 && y < 0)
                WriteLine("The coordinate point ({0}, {1}) lies in the Third quadrant.", x, y);
            else 
                WriteLine("The coordinate point ({0}, {1}) lies in the Fourth quadrant.", x, y);
            ReadLine();
        }
    }
}
