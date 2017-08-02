using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public static class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my palindrome program. A palindrome is a word or phrase\nthat reads the same backwards and forwards. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input as many characters you please and I will tell you whether or not\nthey form a palindrome: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me to check whether or it is a\npalindrome. Please try again: ");
        }

        public static void IsAPalindrome(string userInput)
        {
            Console.WriteLine($"\nCongratulations {userInput} is indeed a palindrome.");
        }

        public static void IsNotAPalindrome(string userInput)
        {
            Console.WriteLine($"\nSorry but {userInput} is not a palindrome.");
        }
    }
}
