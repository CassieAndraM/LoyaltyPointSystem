using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Loyalty_Point_System
{
    public class Login
    {
        public static void UserLogin()
        {
            Console.WriteLine("LOGIN YOUR ACCOUNT");
            string accountname, pincode, accountname1, pincode1 = string.Empty;

            Console.WriteLine("Enter accountname: ");
            accountname = Console.ReadLine();

            using (StreamReader sr = new StreamReader(File.Open("C:\\Users\\cassandra\\source\\repos\\Loyalty_Point_System\\CreateUser.txt", FileMode.Open)))
            {
                accountname1 = sr.ReadLine();
                pincode1 = sr.ReadLine();
                sr.Close();
            }

            if (accountname == accountname1)
            {
                Console.WriteLine("\nLogin Successful!\n", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
                Program.TransferPoints();
            }
            else
            {

                Console.WriteLine("\nYou have entered the incorrect information. Login Failed.", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("Please login again.\n");
                Console.ResetColor();
                Login.UserLogin();
            }
            Console.Read();
        }
    }
}
