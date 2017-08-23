using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefix_Again_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Prefix Again program where you will input a string and anumber n. The first n letters of your string will be the prefix and I will tell you whether or not the prefix appears again in your string. Press enter to\ncontinue.");
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

        public static void AppearsAgain(string prefix)
        {
            Console.WriteLine($"\nCongratulations {prefix} appears again in your string!!!\nPress enter to close the program.");
        }

        public static void DoesNotAppearAgain(string prefix)
        {
            Console.WriteLine($"\nUnfortunately {prefix} does not appear again in your string.\nPress enter to close the program.");
        }
    }
}
