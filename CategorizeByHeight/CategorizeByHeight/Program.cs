using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CategorizeByHeight
{
    class Program
    {
        /* The following code is Categorize the Person According to Their Height
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #06
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is Categorize the Person According to Their Height");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's categorize the person according to their height:");
            double height = 0;
            Write("Please set your height (in cm): ");
            height = ToDouble(ReadLine());
            while (height <= 0)
            {
                Write("Your height (in cm) should be positive. Please, try again: ");
                height = ToDouble(ReadLine());
                while (height > 220)
                {
                    WriteLine("Are you sure about your height? You set a value more than 220cm.");
                    Write("Please, set your height (in cm) again: ");
                    height = ToDouble(ReadLine());
                }
            }
            while (height > 220)
            {
                WriteLine("Are you sure about your height? You set a value more than 220cm.");
                Write("Please, set your height (in cm) again: ");
                height = ToDouble(ReadLine());
                while (height <= 0)
                {
                    Write("Your height (in cm) should be positive. Please, try again: ");
                    height = ToDouble(ReadLine());
                }
            }
            if (height > 0 && height < 155)
                Write("Your height ({0}cm) is below the average (155cm).", height);
            else if (height == 155)
                Write("You height ({0}cm) is equal to the average (155cm).", height);
            else if (height > 155 && height <= 220)
                Write("Your height ({0}cm) is above the average (155cm).", height);
            ReadLine();
        }
    }
}
