using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CalculateProfitAndLoss
{
    class Program
    {
        /* The following code is Calculate Profit and Loss on a Transaction
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #05-Problem Statement #14
         * Date: 2018-03-08 */
        static void Main(string[] args)
        {
            WriteLine("The program calculates profit and loss on a transaction.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's calculate profit and loss on a transaction:");
            double pay = 0;
            double receive = 0;
            double calculate = 0;
            Write("Please input how many you pay: ");
            pay = ToDouble(ReadLine());
            while (pay < 0)
            {
                Write("Please input how many you pay again (pay >= 0): ");
                pay = ToDouble(ReadLine());
            }
            Write("Please input how many you receive: ");
            receive = ToDouble(ReadLine());
            while (receive < 0)
            {
                Write("Please input how many you receive again (receive >= 0): ");
                receive = ToDouble(ReadLine());
            }
            calculate = receive - pay;
            if (calculate > 0)
                Write("You can book your profit amount: {0}", calculate);
            else if (calculate < 0)
                Write("You need to take care about your loss amount: {0}", calculate);
            else
                Write("You do not have profit or loss amount: {0}", calculate);
            ReadLine();
        }
    }
}
