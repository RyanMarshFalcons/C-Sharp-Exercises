using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Characters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Replace Characters program where you will enter a\nstring, a character, and the index of your string at which you would like to\nreplace the current character with your new one. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input as many characters you please to form your string: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character to create a valid string. Please try\nagain: ");
        }

        public static void EnterCharacter()
        {
            Console.Write("\nWhat is the character that you would like me to replace an existing character\nwith: ");
        }

        public static void NotACharacter(string input)
        {
            Console.Write($"\nSorry but {input} is not a character. What is the character that you\nwould like me to replace an existing character with: ");
        }

        public static void EnterIndex(char userCharacter)
        {
            Console.Write($"\nPlease enter the index of the character in your string that you want me to\nreplace with {userCharacter}: ");
        }

        public static void NotANumber(string input, char userCharacter)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the index of the\ncharacter in your string that you want me to replace with {userCharacter}: ");
        }

        public static void NotAValidIndex(string input, int maxIndex, char userCharacter)
        {
            Console.Write($"\nSorry but {input} is not a valid index. The index must be between 0 and {maxIndex}.\nPlease enter the index of the character in your string that you want me to\nreplace with {userCharacter}: ");
        }

        public static void DisplayNewString(string newString, char userCharacter, int index)
        {
            Console.WriteLine($"\nAfter replacing the character at index {index} with {userCharacter} your newly formed string is:\n{newString}\nPress enter to contine.");
            Console.ReadLine();
        }

        public static void ReplaceAnotherCharacter()
        {
            Console.Write("Would you like to replace another character in your string? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for using my Replace Characters program. I hope that you enjoyed usingit. Press enter to close the program.");
        }
    }
}
