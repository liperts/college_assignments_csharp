using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ShowsYourCurrentBalanceDoWhileLoop
{
    class Program
    {
        /* The following code Shows Your Current Balance - Do While Version
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #8
         * Date: 2018-03-27 */
        static void Main(string[] args)
        {
            WriteLine("It shows your current balance - do while version.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show your current balance - do while version:");
            WriteLine();
            double balance = 10000;
            int year = 2018;
            string answer = " ";
            //This is the head of the table. We can use '\t' for a horizontal tab.
            WriteLine("Balance \t|\tYear");
            WriteLine("10,000 $\t|\t2018");
            WriteLine();
            do
            {
                //We need to ask the user if he/she wants to see the balance of...
                //... the next year.
                Write("Do you want to continue for the next year (y or n)? ");
                answer = ReadLine();
                WriteLine();
                //If 'yes' we need to show the next balance.
                if (answer == "y" || answer == "Y")
                {
                    balance = (balance * 1.04);
                    ++year;
                    //This is the way to print the number like '10,000'.
                    WriteLine("{0:0,0} $\t|\t{1}", balance, year);
                    WriteLine();
                }
            }
            //To finish the loop, the user needs to answer something different than...
            //... 'y' or 'Y'.
            while (answer == "y" || answer == "Y");
            //After exiting the loop, a farewell message is printed.
            Write("Thank you for choosing our bank. Have a wonderful day!");
            Write(ReadLine());
        }
    }
}
