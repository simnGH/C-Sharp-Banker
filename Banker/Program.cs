using System;
using System.IO;
using System.Collections.Generic;

// To do:
// In OpenAccount(), have option to re-enter bank details
// In OpenAccount(), only accept certain things for details

namespace Banker
{
    class Program
    {
        // We're going to do a lot of work with a list, so we initiate the empty list up top
        public static List<BankAccount> accountsList = new List<BankAccount>();

        // Array menu to print
        public static void ShowMenu()
        {
            string[] menu = {
                "1. Open account [O]",
                "2. List accounts [L]",
                "3. Bring up account details [A]",
                "4. Make deposit [D]",
                "5. Make withdrawal [W]",
                "6. Transfer [T]",
                "7. Exit program [E]"
            };
            Console.WriteLine("\nSelect from menu:\n- - - - -");
            foreach(var item in menu)
            {
            Console.WriteLine(item);
            }
            Console.WriteLine(); // Gives a line of space
        } 

        public static void OpenAccount()
        {
            Console.WriteLine("\nEnter Sort Code");
            int sortCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Account Number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Account Type - Current or Savings");
            string accountType = Console.ReadLine();
            Console.WriteLine("\nEnter First Name");
            string forename = Console.ReadLine();
            Console.WriteLine("\nEnter Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("\nEnter Opening Balance");
            double balance = Convert.ToDouble(Console.ReadLine());
            // Will now writes all details which have been entered
            Console.WriteLine($"\nYou have entered:\n- - - - -\nSort Code: {sortCode}\nAccount Number: {accountNumber}\nAccount Type: {accountType}\nFirst Name: {forename}\nSurname: {surname}\nOpening Balance: {balance}\n- - - - -\nPress C to confirm, or R to re-enter details, or any other key to exit\n");
            // Commits all entered into account
            accountsList.Add(new BankAccount(sortCode,accountNumber,accountType,forename,surname,balance));
        }

        public static void PrintAccounts() 
        {
            foreach (BankAccount account in accountsList)
            {
                Console.WriteLine($"\nSort Code: {account.sortCode}\nAccount Number: {account.accountNumber}\nAccount Type: {account.accountType}\nFirst Name: {account.forename}\nSurname: {account.surname}\nOpening Balance: {account.balance}\n");
            }
        }

        static void Main(string[] args)
        {
            bool noExit = true;
            while (noExit == true)
            {
                ShowMenu();     // Main program shows the menu
                string menuSelect = Console.ReadLine();
                if (menuSelect == "1" || menuSelect == "O" || menuSelect == "o")
                {
                    OpenAccount();
                }
                else if (menuSelect == "2" || menuSelect == "L" || menuSelect == "l")
                {
                    PrintAccounts();
                }
                else if (menuSelect == "7" || menuSelect == "E" || menuSelect == "e")
                {
                    noExit = false;
                }
                else
                {
                    Console.WriteLine("Invalid command - please select another option");
                }
            }
        }
    }
}
