using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Character_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Insert Character program where you will enter a string, a character, and the index at which you want me to insert that character into\nyour string. Press enter to continue.");
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
            Console.Write("\nWhat is the character that you would like me to insert for you: ");
        }

        public static void NotACharacter(string input)
        {
            Console.Write($"\nSorry but {input} is not a character. What is the character that you would like me to insert for you: ");
        }

        public static void EnterIndex(string userCharacter)
        {
            Console.Write($"\nPlease enter the index at which you wish to insert {userCharacter} into your string: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void CannotBeNegative()
        {
            Console.Write($"\nSorry but the index cannot be a negative number. Please input a number: ");
        }

        public static void NotAValidIndex(string input, int stringLength)
        {
            Console.Write($"\nSorry but {input} is not a valid index because your string is only {stringLength} characters\nlong. Please input a number: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nYour newly formed string is: {newString}\nPress enter to close the program.");
        }
    }
}
