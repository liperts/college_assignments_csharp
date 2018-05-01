using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VolumeOfSphere
{
    class Program
    {
        /*The following code is Volume of Sphere
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Student No: 300963168
         * Group No: 02
         * Assignment #03-Math Problem 02
         * Date: 2018-02-14 */
        static void Main(string[] args)
        {
            WriteLine("The program is resolving Volume of Sphere");
            WriteLine("Written by: Lipe Teixeira");
            double pi = 3.1416, volumeSphere;
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
            //Calculate the volume of sphere
            //(using '3.0' to force a floating point quotient, 
            //and the 'power' function to calculate the square)
            volumeSphere = 4/3.0 * pi * (Math.Pow(radiusDouble, 3));
            //The following line is for printing the result
            //(using the 'round' function to set two decimals places) 
            WriteLine("The value of Volume of Sphere is: {0}", Math.Round(volumeSphere, 2));
            //The following code is for when you press F5 and 
            //want to see the result before it is closed
            ReadLine();
        }
    }
}