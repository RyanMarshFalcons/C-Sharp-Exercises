using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Five_Chars_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Index Five Chars program where you will enter a string\nand an index and I will give you a string of five characters from that index.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input a series of characters to form your string: ");
        }

        public static void AtLeastFiveCharacters()
        {
            Console.Write("\nYou must input at least five characters to create a valid string. Please try\nagain: ");
        }

        public static void EnterIndex()
        {
            Console.Write("\nEnter the index you want me to start at in your string: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Enter the index you want me to start at in your string: ");
        }

        public static void OutOfRange(string input, int maxIndex)
        {
            Console.Write($"\nSorry but {input} is out of range. From the string that you input in order for\nme to form a five character string the range of indexes that I can accept\nis 0 to {maxIndex}. Enter the index you want me to start at in your string: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nYour new string is: {newString}\nPress enter to close the program.");
        }
    }
}
