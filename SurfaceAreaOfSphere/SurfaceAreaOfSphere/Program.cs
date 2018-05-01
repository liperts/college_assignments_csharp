using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SurfaceAreaOfSphere
{
    class Program
    {
        /*The following code is Surface Area of Sphere
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Student No: 300963168
         * Group No: 02
         * Assignment #03-Math Problem 01
         * Date: 2018-02-14 */
        static void Main(string[] args)
        {
            WriteLine("The program is resolving Surface Area of Sphere");
            WriteLine("Written by: Lipe Teixeira");
            double pi = 3.1416, areaSphere;
            string radiusString;
            double radiusDouble;
            Write("Please, input radius: ");
            //The Reza's file "Microsoft Visual C#_Ch02_PPT" 
            //shows how to convert variable
            radiusString = ReadLine();
            radiusDouble = Convert.ToDouble(radiusString);
            //While the radius of a sphere is less than or equal to 0...
            while (radiusDouble <= 0)
            {
                //...is necessary to input the radius' value again
                Write("Error! Please input radius > 0: ");
                radiusString = ReadLine();
                radiusDouble = Convert.ToDouble(radiusString);
            }
            //Calculate the surface area of sphere
            //(using the 'power' function to calculate the square)
            areaSphere = 4 * pi * (Math.Pow(radiusDouble, 2));
            //The following line is for printing the result
            //(using the 'round' function to set two decimals places) 
            WriteLine("The value of Surface Area of Sphere is: {0}", Math.Round(areaSphere, 2));
            //The following code is for when you press F5 and 
            //want to see the result before it is closed
            ReadLine();
        }
    }
}