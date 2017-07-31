using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Division program where you will enter two numbers and I will tell you what the quotient of those two numbers is. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("\nPlease enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void DisplayQuotient(double num1, double num2, double quotient)
        {
            Console.WriteLine($"\nThe quotient of {num1} divided by {num2} is {quotient}");
        }
    }
}
