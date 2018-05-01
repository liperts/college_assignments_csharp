using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CreateATriangle
{
    class Program
    {
        /* The following code is Check Whether a Triangle Can Be Formed by the Given Angles
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #12
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is check whether a triangle can be formed by the given angles.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check whether a triangle can be formed by the given angles:");
            WriteLine("Remember that: the sum of the three angles must be 180.");
            int firstAngle = 0;
            int secondAngle = 0;
            int thirdAngle = 0;
            int sumAngles = 0;
            int equalsAngles = 0;
            int obtuseAngle = 0;
            do
            {
                Write("Please input the value for the first angle: ");
                firstAngle = ToInt32(ReadLine());
                while (firstAngle <= 0)
                {
                    Write("The angle should be > 0. Please try again (first angle): ");
                    firstAngle = ToInt32(ReadLine());
                }
                Write("Please input the value for the second angle: ");
                secondAngle = ToInt32(ReadLine());
                while (secondAngle <= 0)
                {
                    Write("The angle should be > 0. Please try again (second angle): ");
                    secondAngle = ToInt32(ReadLine());
                }
                Write("Please input the value for the third angle: ");
                thirdAngle = ToInt32(ReadLine());
                while (thirdAngle <= 0)
                {
                    Write("The angle should be > 0. Please try again (third angle): ");
                    thirdAngle = ToInt32(ReadLine());
                }
                sumAngles = firstAngle + secondAngle + thirdAngle;
                if (sumAngles > 180)
                {
                    WriteLine("The triangle is NOT valid. Please try again.");
                    WriteLine();
                }
                if (firstAngle == secondAngle)
                    equalsAngles = firstAngle;
                else if (firstAngle == thirdAngle)
                    equalsAngles = firstAngle;
                else if (secondAngle == thirdAngle)
                    equalsAngles = secondAngle;
                if (firstAngle > 90)
                    obtuseAngle = firstAngle;
                else if (secondAngle > 90)
                    obtuseAngle = secondAngle;
                else if (thirdAngle > 90)
                    obtuseAngle = thirdAngle;
            }
            while (sumAngles != 180);
            WriteLine();
            WriteLine("The triangle is valid.");
            if (firstAngle != secondAngle && firstAngle != thirdAngle && secondAngle != thirdAngle)
                WriteLine("This is an Scalene Triangle, because that has three unequal angles {0}, {1}, and {2}.", firstAngle, secondAngle, thirdAngle);
            else if (firstAngle == secondAngle && firstAngle == thirdAngle)
                WriteLine("This is an Equilateral Triangle, because that has three equal angles (60).");
            else if (firstAngle == secondAngle || firstAngle == thirdAngle || secondAngle == thirdAngle)
                WriteLine("This is an Isosceles Triangle, because that has two equal angles {0}.", equalsAngles);
            if (firstAngle == 90 || secondAngle == 90 || thirdAngle == 90)
                WriteLine("This is a Right Triangle, because that has an angle of 90.");
            else if (firstAngle > 90 || secondAngle > 90 || thirdAngle > 90)
                WriteLine("This is an Obtuse Triangle, because one of the angles ({0}) > 90.", obtuseAngle);
            else if (firstAngle < 90 && secondAngle < 90 && thirdAngle < 90)
                WriteLine("This is an Acute Triangle, because all of angles ({0}, {1}, and {2}) < 90.", firstAngle, secondAngle, thirdAngle);
            ReadLine();
        }
    }
}
