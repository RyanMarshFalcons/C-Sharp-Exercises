using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Characters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Remove Characters program where you will enter a string and then input any character(s) that you would like me to remove from your\nstring. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input a series of characters to form your string: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character to create a valid string. Please try\nagain: ");
        }

        public static void EnterCharacter()
        {
            Console.Write("\nWhat is the character that you would like me to remove all instances of from\nyour string: ");
        }

        public static void NotACharacter(string input)
        {
            Console.Write($"\nSorry but {input} is not a character. What is the character that\nyou would like me to remove all instances of from your string: ");
        }

        public static void DisplayNewString(string newString, char character)
        {
            Console.WriteLine($"\nAfter removing all the instances of {character} from your string your new string is:\n{newString}\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void RemoveAnotherCharacter()
        {
            Console.Write("Would you like to remove another character from your string? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void StringIsEmpty()
        {
            Console.WriteLine("Your string is completely empty. There are no more characters to remove. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for using my Remove Characters program. I hope that you enjoyed it.\nPress enter to close the program.");
        }
    }
}
