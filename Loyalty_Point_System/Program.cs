using System;
using System.IO;

namespace Loyalty_Point_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int TotalMilkShakeBill = 0;
            double TotalPoints = 0.00;
            string UserDecisionToContinue = String.Empty;
            string TransferDecision = String.Empty;
            string account = String.Empty;
            do
            {
                int UserSelectionFromMenu = 0;
                try
                {
                    Console.WriteLine("Please select from below menu");
                    Console.WriteLine("{0, -8}{1, -15}{2, 15}", "SR.NO", "COLD BREW", "Price");
                    Console.WriteLine("{0, -8}{1, -15}{2, 15}", "1", "Iced Americano", "85 php");
                    Console.WriteLine("{0, -8}{1, -15}{2, 15}", "2", "Iced Latte", "85 php");
                    Console.WriteLine("{0, -8}{1, -15}{2, 13}", "3", "Caramel Macchiato", "85 php");
                    Console.WriteLine("{0, -8}{1, -15}{2, 15}", "4", "Spanish Latte", "85 php");
                    Console.WriteLine("{0, -8}{1, -15}{2, 15}", "5", "Choco Mocha", "85 php");
                    Console.WriteLine("{0, -8}{1, -15}{2, 11}", "6", "Sweetened Cold Brew", "85 php");
                    Console.WriteLine("{0, -8}{1, -15}{2, 14}", "7", "Caramelark Latte", "85 php");
                    Console.WriteLine("{0, -8}{1, -15}{2, 16}", "8", "Matcha Latte", "85 php\n");

                    Console.Write("Enter the number you want to order: ");
                    UserSelectionFromMenu = Convert.ToInt32(Console.ReadLine());

                    switch (UserSelectionFromMenu)
                    {
                        case 1:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.10;
                            break;
                        case 2:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.20;
                            break;
                        case 3:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.30;
                            break;
                        case 4:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.40;
                            break;
                        case 5:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.50;
                            break;
                        case 6:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.60;
                            break;
                        case 7:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.70;
                            break;
                        case 8:
                            TotalMilkShakeBill += 85;
                            TotalPoints += 0.80;
                            break;
                        default:
                            Console.WriteLine($"Your Choice {UserSelectionFromMenu} is invalid");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Occured: {ex}");
                }
                do
                {
                    Console.WriteLine("\nDo you want to continue Yes or No?");
                    UserDecisionToContinue = Console.ReadLine().ToUpper();

                    if (UserDecisionToContinue != "YES" && UserDecisionToContinue != "NO")
                    {
                        Console.WriteLine($"Your choice is {UserDecisionToContinue} is invalid");
                    }
                }

                while (UserDecisionToContinue != "YES" && UserDecisionToContinue != "NO");
            }
            while (UserDecisionToContinue.ToUpper() != "NO");
            Console.WriteLine($"Your bill amount is {TotalMilkShakeBill}");
            Console.WriteLine($"The points you get is {TotalPoints}");

            Console.WriteLine("Do you have an account to transfer your points?");
            do
            {
                Console.WriteLine("Yes or No?");
                account = Console.ReadLine().ToUpper();

                if (account != "YES" && account != "NO")
                {
                    Console.WriteLine($"Your choice is {account} is invalid");
                }
                else if (account.ToUpper() == "NO")
                {
                    CreateUser.UserCreation();
                }
                else if (account.ToUpper() == "YES")
                {
                    Login.UserLogin();
                }
            }

            while (TransferDecision != "YES" && TransferDecision != "NO");
        }
        public static void TransferPoints()
        {
            Console.WriteLine("You have successfully transfer your points to your account");
            using (StreamWriter sw = new StreamWriter(File.Create("C:\\Users\\ADMIN\\source\\repos\\RewardPoints\\RewardPoints\\TransferPoints.txt")))
            {
                sw.WriteLine($"Student Number: ");
                sw.WriteLine($"Total points: ");
                sw.Close();
            }
            System.Environment.Exit(0);
        }
    }
}
