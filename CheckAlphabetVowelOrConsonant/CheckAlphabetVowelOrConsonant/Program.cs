using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckAlphabetVowelOrConsonant
{
    class Program
    {
        /* The following code is Check Whether an Alphabet is a Vowel or Consonant
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #13
         * Date: 2018-03-08 */
        static void Main(string[] args)
        {
            WriteLine("The program is check whether an alphabet is a vowel or consonant.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check whether an alphabet is a vowel or consonant:");
            char alphabet = '0';
            Write("Please set the alphabet: ");
            alphabet = ToChar(ReadLine());
            /*if (Char.IsLetter(alphabet))
            {
                switch (alphabet)
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        WriteLine("The alphabet is a vowel.");
                        break;
                    default:
                        WriteLine("The alphabet is a consonant.");
                        break;
                }
            }
            else
                WriteLine("This is not a alphabet. Please try again.");*/
            if (Char.IsLetter(alphabet))
            {
                if (alphabet == 'a' || alphabet == 'A' || alphabet == 'e' || alphabet == 'E' || alphabet == 'i'
                || alphabet == 'I' || alphabet == 'o' || alphabet == 'O' || alphabet == 'u' || alphabet == 'U')
                    Write("The alphabet is a vowel.");
                else
                    Write("The alphabet is a consonant.");
            }
            else
                WriteLine("This is not a alphabet. Please try again.");
            ReadLine();
        }
    }
}
