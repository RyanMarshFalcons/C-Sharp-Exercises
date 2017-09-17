using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhn_Formula_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Luhn Formula program where you will enter a number and then I willtell you whether or not your number is valid by using the Luhn Formula. The LuhnFormula is used to validate a variety of identification numbers, such as credit card numbers and Canadian Social Insurance Numbers. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserNumber()
        {
            Console.Write("\nPlease enter your number. Spaces are allowed, other non-digit characters are notallowed: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nSorry but your number must be at least two digits long for your string to be\nvalid. Please enter your number: ");
        }

        public static void ContainsLettersOrSymbols()
        {
            Console.Write("\nSorry but your number cannot contain any letters or symbols. Please enter your\nnumber: ");
        }

        public static void IsValid()
        {
            Console.WriteLine("\nCongratulations according to the Luhn Formula your number is valid!!! Press\nenter to close the program.");
        }

        public static void IsNotValid()
        {
            Console.WriteLine("\nUnfortunately according to the Luhn Formula your number is invalid. Press enter to close the program.");
        }
    }
}
