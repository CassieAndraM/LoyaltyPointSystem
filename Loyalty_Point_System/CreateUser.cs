using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AppLayer;

namespace Loyalty_Point_System
{
    public class CreateUser
    {
        public static void UserCreation()
        {
            Console.WriteLine("Now we create a new user");

            List<string> dataList = new List<string>();

            string studNo;
            Console.WriteLine("Enter account name: ");
            studNo = Console.ReadLine().Trim();

            if (LPSValidator.ValidateLoginUser(studNo))
            {
                dataList.Add(studNo);
                Console.WriteLine("Successfully created your account");
                using (StreamWriter sw = new StreamWriter(File.Create("C:\\Users\\cassandra\\source\\repos\\Loyalty_Point_System\\CreateUser.txt")))
                {
                    sw.WriteLine(studNo);
                    sw.Close();
                }
                Login.UserLogin();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }
        }
    }
}
