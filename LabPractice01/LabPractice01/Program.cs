using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace LabPractice01
{
    class Program
    {
        //Frank's version (better than mine):
        static void Main(string[] args)
        {
            const string userName = "ABC", password = "123";
            string user, pass;
            int count = 1;
            Write("Please enter your username: ");
            user = ReadLine();
            WriteLine();
            Write("Please enter your password: ");
            pass = ReadLine();
            WriteLine();
            while (user != userName || pass != password)
            {
                count++;
                if (count <= 3)
                {
                    WriteLine("Either your username or password is wrong");
                    Write("Please enter your username: ");
                    user = ReadLine();
                    WriteLine();
                    Write("Please enter your password: ");
                    pass = ReadLine();
                    WriteLine();
                }
                else
                {
                    WriteLine("Your account is locked for too many wrong attempts");
                    break;
                }
            }
            if (user == userName && pass == password)
            {
                WriteLine("Successful Login");
            }
            WriteLine(ReadLine());
        }
    }
}
