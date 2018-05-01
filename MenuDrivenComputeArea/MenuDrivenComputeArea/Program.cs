using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace MenuDrivenComputeArea
{
    class Program
    {
        /* The following code is a Menu-Driven to Compute the Area of Geometrical Shapes
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #19
         * Date: 2018-03-09 */
        static void Main(string[] args)
        {
            WriteLine("It reads the user's choice, and compute the corresponding area.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's started to calculate a geometric area:");
            WriteLine();
            WriteLine(" 1 - Triangle");
            WriteLine(" 2 - Square");
            WriteLine(" 3 - Circle");
            WriteLine(" 4 - Rectangle");
            WriteLine(" 5 - Cylinder");
            WriteLine(" 6 - Trapezoid");
            WriteLine(" 7 - Hexagon");
            WriteLine(" 8 - Pentagon");
            WriteLine(" 9 - Diamond");
            WriteLine("10 - Parallelogram");
            WriteLine("11 - Tetrahedron");
            WriteLine("12 - Cone");
            WriteLine("13 - Cube");
            WriteLine();
            int shape = 0;
            double smallerBase = 0;
            double height = 0;
            double area = 0;
            double side = 0;
            double radius = 0;
            double pi = PI;
            double length = 0;
            double width = 0;
            double biggerBase = 0;
            double smallerDiagonal = 0;
            double biggerDiagonal = 0;
            Write("Please input your choice (1 - 13): ");
            shape = ToInt32(ReadLine());
            switch (shape)
            {
                case 1:
                    {
                        Write("Please input base of the Triangle: ");
                        smallerBase = ToDouble(ReadLine());
                        while (smallerBase <= 0)
                        {
                            Write("The base should be positive. Please try again: ");
                            smallerBase = ToDouble(ReadLine());
                        }
                        Write("Please input height of the Triangle: ");
                        height = ToDouble(ReadLine());
                        while (height <= 0)
                        {
                            Write("The height should be positive. Please try again: ");
                            height = ToDouble(ReadLine());
                        }
                        area = ((smallerBase * height) / 2);
                        WriteLine("The area of this Triangle is: {0}", Round(area, 2));
                    }
                    break;
                case 2:
                    {
                        Write("Please input side of the Square: ");
                        side = ToDouble(ReadLine());
                        while (side <= 0)
                        {
                            Write("The side should be positive. Please try again: ");
                            side = ToDouble(ReadLine());
                        }
                        area = (Pow(side, 2));
                        WriteLine("The area of this Square is: {0}", Round(area, 2));
                    }
                    break;
                case 3:
                    {
                        Write("Please input radius of the Circle: ");
                        radius = ToDouble(ReadLine());
                        while (radius <= 0)
                        {
                            Write("The radius should be positive. Please try again: ");
                            radius = ToDouble(ReadLine());
                        }
                        area = (pi * (Pow(radius, 2)));
                        WriteLine("The area of this Circle is: {0}", Round(area, 2));
                    }
                    break;
                case 4:
                    {
                        Write("Please input length of the Rectangle: ");
                        length = ToDouble(ReadLine());
                        while (length <= 0)
                        {
                            Write("The length should be positive. Please try again: ");
                            length = ToDouble(ReadLine());
                        }
                        Write("Please input width of the Rectangle: ");
                        width = ToDouble(ReadLine());
                        while (width <= 0)
                        {
                            Write("The width should be positive. Please try again: ");
                            width = ToDouble(ReadLine());
                        }
                        area = (length * width);
                        WriteLine("The area of this Rectangle is: {0}", Round(area, 2));
                    }
                    break;
                case 5:
                    {
                        Write("Please input radius of the Cylinder: ");
                        radius = ToDouble(ReadLine());
                        while (radius <= 0)
                        {
                            Write("The radius should be positive. Please try again: ");
                            radius = ToDouble(ReadLine());
                        }
                        Write("Please input height of the Cylinder: ");
                        height = ToDouble(ReadLine());
                        while (height <= 0)
                        {
                            Write("The height should be positive. Please try again: ");
                            height = ToDouble(ReadLine());
                        }
                        area = ((2 * pi * radius * height) + 2 * pi * (Pow(radius, 2)));
                        WriteLine("The area of this Cylinder is: {0}", Round(area, 2));
                    }
                    break;
                case 6:
                    {
                        Write("Please input the smaller Trapezoid base: ");
                        smallerBase = ToDouble(ReadLine());
                        while (smallerBase <= 0)
                        {
                            Write("The smaller base should be positive. Please try again: ");
                            smallerBase = ToDouble(ReadLine());
                        }
                        Write("Please input the bigger Trapezoid base: ");
                        biggerBase = ToDouble(ReadLine());
                        while (biggerBase <= 0)
                        {
                            Write("The bigger base should be positive. Please try again: ");
                            biggerBase = ToDouble(ReadLine());
                        }
                        Write("Please input height of the Trapezoid: ");
                        height = ToDouble(ReadLine());
                        while (height <= 0)
                        {
                            Write("The height should be positive. Please try again: ");
                            height = ToDouble(ReadLine());
                        }
                        area = (((smallerBase + biggerBase) / 2) * height);
                        WriteLine("The area of this Trapezoid is: {0}", Round(area, 2));
                    }
                    break;
                case 7:
                    {
                        Write("Please input side of the Hexagon: ");
                        side = ToDouble(ReadLine());
                        while (side <= 0)
                        {
                            Write("The side should be positive. Please try again: ");
                            side = ToDouble(ReadLine());
                        }
                        area = (((3 * Sqrt(3)) / 2) * (Pow(side, 2)));
                        WriteLine("The area of this Hexagon is: {0}", Round(area, 2));
                    }
                    break;
                case 8:
                    {
                        Write("Please input side of the Pentagon: ");
                        side = ToDouble(ReadLine());
                        while (side <= 0)
                        {
                            Write("The side should be positive. Please try again: ");
                            side = ToDouble(ReadLine());
                        }
                        area = (0.25 * (Sqrt(5 * (5 + (2 * (Sqrt(5)))))) * (Pow(side, 2)));
                        WriteLine("The area of this Pentagon is: {0}", Round(area, 2));
                    }
                    break;
                case 9:
                    {
                        Write("Please input the smaller Diamond diagonal: ");
                        smallerDiagonal = ToDouble(ReadLine());
                        while (smallerDiagonal <= 0)
                        {
                            Write("The smaller diagonal should be positive. Please try again: ");
                            smallerDiagonal = ToDouble(ReadLine());
                        }
                        Write("Please input the bigger Diamond diagonal: ");
                        biggerDiagonal = ToDouble(ReadLine());
                        while (biggerDiagonal <= 0)
                        {
                            Write("The bigger diagonal should be positive. Please try again: ");
                            biggerDiagonal = ToDouble(ReadLine());
                        }
                        area = ((smallerDiagonal * biggerDiagonal) / 2);
                        WriteLine("The area of this Diamond is: {0}", Round(area, 2));
                    }
                    break;
                case 10:
                    {
                        Write("Please input base of the Parallelogram: ");
                        smallerBase = ToDouble(ReadLine());
                        while (smallerBase <= 0)
                        {
                            Write("The base should be positive. Please try again: ");
                            smallerBase = ToDouble(ReadLine());
                        }
                        Write("Please input height of the Parallelogram: ");
                        height = ToDouble(ReadLine());
                        while (height <= 0)
                        {
                            Write("The height should be positive. Please try again: ");
                            height = ToDouble(ReadLine());
                        }
                        area = (smallerBase * height);
                        WriteLine("The area of this Parallelogram is: {0}", Round(area, 2));
                    }
                    break;
                case 11:
                    {
                        Write("Please input side of the Tetrahedron: ");
                        side = ToDouble(ReadLine());
                        while (side <= 0)
                        {
                            Write("The side should be positive. Please try again: ");
                            side = ToDouble(ReadLine());
                        }
                        area = ((Sqrt(3) * (Pow(side, 2))));
                        WriteLine("The area of this Tetrahedron is: {0}", Round(area, 2));
                    }
                    break;
                case 12:
                    {
                        Write("Please input radius of the Cone: ");
                        radius = ToDouble(ReadLine());
                        while (radius <= 0)
                        {
                            Write("The radius should be positive. Please try again: ");
                            radius = ToDouble(ReadLine());
                        }
                        Write("Please input height of the Cone: ");
                        height = ToDouble(ReadLine());
                        while (height <= 0)
                        {
                            Write("The height should be positive. Please try again: ");
                            height = ToDouble(ReadLine());
                        }
                        area = ((pi * radius) * (radius + (Sqrt((Pow(height, 2) + (Pow(radius, 2)))))));
                        WriteLine("The area of this Cone is: {0}", Round(area, 2));
                    }
                    break;
                case 13:
                    {
                        Write("Please input side of the Cube: ");
                        side = ToDouble(ReadLine());
                        while (side <= 0)
                        {
                            Write("The side should be positive. Please try again: ");
                            side = ToDouble(ReadLine());
                        }
                        area = (6 * (Pow(side, 2)));
                        WriteLine("The area of this Cube is: {0}", Round(area, 2));
                    }
                    break;
                default:
                    WriteLine("Out of the range! Please Please input a number between 1 and 13.");
                    break;
            }
            ReadLine();
        }
    }
}