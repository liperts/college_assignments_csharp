using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CurrentCoursesInAReverseOrder
{
    class Program
    {
        /* The following code Print the Courses in a Reverse Order (Last to the First)
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #09-Program #2
         * Date: 2018-04-04 */
        static void Main(string[] args)
        {
            WriteLine("It prints the courses in a reverse order (last to the first).");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's print the courses in a reverse order (last to the first):");
            WriteLine();
            //We need to use the new concept, array:
            string[] courses = new string[] { "COMM 161", "COMP 100", "COMP 120", "COMP 213",
                "GNED 219", "MATH 175" };
            int count;
            //Set the value of [(array's length) - 1] into the counter, and 
            //... repeats the loop until counter is bigger than or equal to 0. 
            //... The array's lenght starts in '1', but the first position on... 
            //... the array is '0'. So, the positions are from 0 to array's lenght - 1. 
            //We need to decrement the value of 'count' before repeat the loop.
            for (count = (courses.Length) - 1; count >= 0; count--)
            {
                //Print the courses from the last item to the first one.
                WriteLine(courses[count]);
            }
            Write(ReadLine());
        }
    }
}
