using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace DepreciationTable
{
    class Program
    {
        /* The following code Shows the Depreciation Table
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program Bonus Question
         * Date: 2018-03-31 */
        static void Main(string[] args)
        {
            WriteLine("It shows the depreciation table.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's show the depreciation table:");
            WriteLine();
            int year = 1;
            const int depreciation = 4000;
            int valueOfYear = 28000;
            int accDepreciation = 0;
            WriteLine("\t \t \t END-OF-YEAR \t ACCUMULATED");
            WriteLine("YEAR \t DEPRECIATION \t VALUE \t \t DEPRECIATION");
            while (year <= 7)
            {              
                valueOfYear = valueOfYear - depreciation;
                accDepreciation = accDepreciation + depreciation;
                WriteLine("{0} \t {1} \t \t {2} \t \t \t {3}", year, depreciation,
                    valueOfYear, accDepreciation);
                ++year;
            }
            Write(ReadLine());
        }
    }
}
