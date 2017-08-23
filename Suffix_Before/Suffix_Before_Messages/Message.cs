using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suffix_Before_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Suffix Before program where you will input a string and a number n. The last n letters of your string will be the suffix and I will tellyou whether or not the suffix appears earlier in your string. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("\nPlease enter a string of characters: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least two characters for me to be able to form a newstring for you. Please try again: ");
        }

        public static void EnterNumber()
        {
            Console.Write("\nPlease enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void NotValidNumber(string input, int halfStringLength)
        {
            Console.Write($"\nSorry but {input} is not a valid number. Please input a number\nbetween 1 and {halfStringLength}: ");
        }

        public static void AppearsAgain(string suffix)
        {
            Console.WriteLine($"\nCongratulations {suffix} appears before in your string!!!\nPress enter to close the program.");
        }

        public static void DoesNotAppearAgain(string suffix)
        {
            Console.WriteLine($"\nUnfortunately {suffix} does not appear before in your string.\nPress enter to close the program.");
        }
    }
}
