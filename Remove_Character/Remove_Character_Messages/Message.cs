using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Character_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Remove Character program where you will enter a string\nand then the index at which you want me to remove a character from your string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Input as many characters you please to form your string: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character to create a valid string. Please try\nagain: ");
        }

        public static void EnterIndex()
        {
            Console.Write("\nPlease enter the index at which you wish to remove a character from your\nstring: ");
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
