using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace EligibilityOfAdmission
{
    class Program
    {
        /* The following code is Find the Eligibility of Admission for a Professional Course
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #10
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is find the eligibility of admission for a professional course");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's find the eligibility of admission for a professional course:");
            int phy = 0;
            int chem = 0;
            int maths = 0;
            int total = 0;
            Write("Please input the marks obtained in Physics: ");
            phy = ToInt32(ReadLine());
            while (phy < 0 || phy > 100)
            {
                Write("The mark should be > 0 and < 100. Please input the Physics' mark again: ");
                phy = ToInt32(ReadLine());
            }
            Write("Please input the marks obtained in Chemistry: ");
            chem = ToInt32(ReadLine());
            while (chem < 0 || chem > 100)
            {
                Write("The mark should be > 0 and < 100. Please input the Chemistry's mark again: ");
                chem = ToInt32(ReadLine());
            }
            Write("Please input the marks obtained in Mathematics: ");
            maths = ToInt32(ReadLine());
            while (maths < 0 || maths > 100)
            {
                Write("The mark should be > 0 and < 100. Please input the Mathematics' mark again: ");
                maths = ToInt32(ReadLine());
            }
            total = phy + chem + maths;
            if (phy >= 55 && chem >= 50 && maths >= 65 && total >= 180)
                WriteLine("The candidate is eligible for admission.");
            else
                WriteLine("The candidate is NOT eligible for admission.");
            ReadLine();
        }
    }
}
