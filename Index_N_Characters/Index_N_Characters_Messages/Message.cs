using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_N_Characters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Index N Characters program where you will enter a stringand an index and how many characters from that index you would like a new stringformed from. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input a series of characters to form your string: ");
        }

        public static void TooShort()
        {
            Console.Write("\nYou must input at least one character to create a valid string. Please try\nagain: ");
        }

        public static void EnterIndex()
        {
            Console.Write("\nEnter the index you want me to start at in your string: ");
        }

        public static void NotAValidIndex(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Enter the index you want me to\nstart at in your string: ");
        }

        public static void IndexOutOfRange(string input, int maxIndex)
        {
            Console.Write($"\nSorry but {input} is out of range. Your string starts at index 0 and goes up\nto index {maxIndex}. Enter the index you want me to start at in your string: ");
        }

        public static void EnterNumberCharacters()
        {
            Console.Write("\nEnter how many characters you want to retrieve after the index: ");
        }

        public static void NotAValidNumChars(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Enter how many characters you want\nto retrieve after the index: ");
        }

        public static void NumCharsOutOfRange(string input, int maxNumChars)
        {
            Console.Write($"\nSorry but {input} is out of range. Your number must be between 1 and {maxNumChars} because\nthere are {maxNumChars} characters from your index to the end of your sring. Enter how\nmany characters you want to retrieve after the index: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nYour new string is: {newString}\nPress enter to close the program.");
        }
    }
}
