using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckUsernameAndPasswordWhileVersion
{
    class Program
    {
        /* The following code is Check Username and Password - While Version
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #1
         * Date: 2018-03-27 */
        static void Main(string[] args)
        {
            WriteLine("It checks username and password - while version.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check username and password - while version:");
            WriteLine();
            //The value of 'userName' and 'password' must be the same all time...
            //(to check). So, we can use 'const' to keep the value constant.
            const string userName = "ABC", password = "123";
            string user, pass;
            //The value of 'count' is '1' in the beggining, because we try...
            //... to check at least one time.
            int count = 1;
            Write("Please enter your username: ");
            user = ReadLine();
            WriteLine();
            Write("Please enter your password: ");
            pass = ReadLine();
            WriteLine();
            //Here, we use the 'while' loop to check whether the user input...
            //... is the same of we set for 'userName' and 'password'.
            //If is not the same, we need to repeat the code within the 'while loop'.
            while (user != userName || pass != password)
            {
                //Every time we try again, 'count' needs to increase.
                count++;
                //While 'count' is less than or equal to 3, we need to try again.
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
                //After three wrong attempts, the login will be locked.
                else
                {
                    Write("Your account is locked for too many wrong attempts");
                    //We need to use the 'break' keyword to break (stop) the loop...
                    //... after three wrong tries and exit the loop.
                    break;
                }
            }
            //When we leave the loop, we need to check again if the user set...
            //... the right information for 'user' and for 'pass'.
            if (user == userName && pass == password)
            {
                //If it is right, the user needs to know.
                WriteLine("Successful Login");
            }
            //If it is wrong (after three tries and display the 'lock message'),...
            //... finish the program.
            WriteLine(ReadLine());
        }
    }
}
