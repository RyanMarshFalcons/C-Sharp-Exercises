using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;


namespace Exact_Change
{
    public static class Message
    {
        public static void Welcome()
        {
            Console.Write("Welcome to Ryan's Cash Register Exercise. Please input the purchase price of \nyour transaction: $");
        }

        public static void GetCash()
        {
            Console.Write("\nPlease input the value of the cash that the customer is going to be paying \nwith: $");
        }

        public static void AskWhatsInDrawer()
        {
            Console.WriteLine("\nPlease describe the current contents of the cash register.");
        }

        public static void GiveChange(string changeDue)
        {
            Console.WriteLine($"\nYour change consists of the following amounts of denominations arranged from \nhighest to lowest: {changeDue}");
        }
        public static void IsEmpty()
        {
            Console.WriteLine("\nNo input was given so I cannot do a transaction for you.");
        }

        public static void IsZero()
        {
            Console.WriteLine("\nSorry but neither the price nor the payment can be zero.");
        }

        public static void IsNotAnInteger(string userInput)
        {
            Console.WriteLine($"\nSorry but {userInput} is not an integer.");
        }

        public static void IsNotADecimal(string userInput)
        {
            Console.WriteLine($"\nSorry but {userInput} is not a decimal.");
        }

        public static void IsNegative()
        {
            Console.WriteLine("\nSorry but neither the price, the payment, nor the number of coins and bills of \na denomination can be negative.");
        }

        public static void HasTooManyTrailingDigits()
        {
            Console.WriteLine("\nSorry but only two digits after the decimal point are allowed when dealing with transactions in currency.");
        }
    }
}
