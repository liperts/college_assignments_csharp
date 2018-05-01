using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckEligibilityToVote
{
    class Program
    {
        /* The following code is Checking If the Brazilian is Eligible or Not to Vote
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #05
         * Date: 2018-03-07 */
        static void Main(string[] args)
        {
            WriteLine("The program is Checking If the Brazilian is Eligible or Not to Vote");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check if the Brazilian is eligible or not to vote:");
            int age = 0;
            char wantVote = '0';
            char registerVote = '0';
            Write("Please set your age: ");
            age = ToInt32(ReadLine());
            if (age < 16)
                WriteLine("You not eligible to vote yet.");
            else if (age == 16 || age == 17)
            {
                Write("You can vote. Do you want (y or n)? ");
                wantVote = ToChar(ReadLine());
                if (Char.IsLetter(wantVote))
                {
                    switch (wantVote)
                    {
                        case 'y':
                            Write("Did you make a register to vote (y or n)? ");
                            registerVote = ToChar(ReadLine());
                            if (registerVote == 'y')
                                WriteLine("You are eligible to vote.");
                            else
                                WriteLine("You need to make a register to vote.");
                            break;
                        case 'n':
                            WriteLine("If you change your mind, please make a register to vote.");
                            break;
                        default:
                            WriteLine("You need to choose 'y' or 'n' to answer the question. Please try again.");
                            break;
                    }
                }
                else
                    WriteLine("You should input 'y' or 'n'. Please try again.");
            }
            else if (age >= 18 && age < 70)
                Write("You are eligible to vote.");
            else
                Write("Is not necessary to vote, but you can do it, if you want.");
            ReadLine();
        }
    }
}
