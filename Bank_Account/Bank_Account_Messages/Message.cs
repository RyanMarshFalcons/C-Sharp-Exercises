using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to the Bank of Ryan. Congragulations on your decision to open up a new account here. Press enter to continue.");
            Console.ReadLine();
        }

        public static void Selections()
        {
            Console.WriteLine("\nWould you like to: \n1)Make a deposit \n2)Make a withdrawal \n3)Check your current balance \n4)Close your account");
        }

        public static void Not123or4(string input)
        {
            Console.Write($"\nSorry but {input} is not a valid input. Please input 1, 2, 3, or 4\nto procede: ");
        }

        public static void MakeADeposit()
        {
            Console.Write($"\nHow much are you depositing today: $");
        }

        public static void MakeAWithdrawal()
        {
            Console.Write("\nHow much are you withdrawaing today: $");
        }

        public static void NotANumber(string input, string withdrawalOrDeposit)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input how much you would like to {withdrawalOrDeposit}: $");
        }

        public static void MustBePositive(string withdrawOrDeposit)
        {
            Console.Write($"\nWithdrawals and deposits can only be positive. Please input how much you would\nlike to {withdrawOrDeposit}: $");
        }

        public static void ShowCurrentBalance(double balance)
        {
            Console.WriteLine($"\nThe current balance of your account is ${Math.Round(balance, 2)}");
        }

        public static void InsufficientFunds(double withdrawalAmount, double balance)
        {
            Console.WriteLine($"\nSorry but I am unable to fulfill your request to withdraw ${withdrawalAmount}\nsince your current balance is only ${Math.Round(balance, 2)}");
        }
        
        public static void CloseAccount(double balance)
        {
            Console.WriteLine($"\nIt was a pleasure doing business with you. Here is the ${Math.Round(balance, 2)} that was\nin your accout. Press enter to continue.");
        }
        
    }
}
