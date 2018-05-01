using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckUsernameAndPasswordDoWhileVersion
{
    class Program
    {
        /* The following code is Check Username and Password - Do While Version
         * COURSE COMP100
         * Written by: Lipe Teixeira
         * Assignment #08-Program #2
         * Date: 2018-03-27 */
        static void Main(string[] args)
        {
            WriteLine("It checks username and password - do while version.");
            WriteLine("Written by: Lipe Teixeira");
            WriteLine();
            WriteLine("Let's check username and password - do while version:");
            WriteLine();
            //The value of 'userName' and 'password' must be the same all time...
            //(to check). So, we can use 'const' to keep the value constant.
            const string userName = "ABC", password = "123";
            string user = " ", pass = " ";
            //The value of 'count' is '0' in the beggining.
            int count = 0;
            //Here, we use the 'do while' loop to check whether the user input...
            //... is the same of we set for 'userName' and 'password'.
            //If is not the same, we need to repeat the code within the 'do while loop'.
            do
            {
                //First of all, we need to increase the value of 'count'.
                count++;
                //While 'count' is less than or equal to 3, we need to try again.
                if (count <= 3)
                {
                    Write("Please enter your username: ");
                    user = ReadLine();
                    Write("Please enter your password: ");
                    pass = ReadLine();
                    WriteLine();
                    //If the user input the wrong 'user' and 'pass'...
                    //... we need to show this information.
                    if (user != userName || pass != password)
                    {
                        WriteLine("Either your username or password is wrong");
                        WriteLine();
                    }
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
            while (user != userName || pass != password);
            //When we leave the loop, we need to check again if the user set...
            //... the right information for 'user' and for 'pass'.
            if (user == userName && pass == password)
            {
                //If it is right, the user needs to know.
                Write("Successful Login");
            }
            //If it is wrong (after three tries and display the 'lock message'),...
            //... finish the program.
            WriteLine(ReadLine());
        }
    }
}
