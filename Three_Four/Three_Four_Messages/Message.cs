using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Four_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Three Four program where you will input a string and I will create a new string by shifting every fifth sixth and seventh characters starting with the first three past the following four and ignoring any excess character(s)at the end. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter a string of characters: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least seven characters for me to be able to form a\nnew string for you. Please try again: ");
        }

        public static void DisplayResult(string newString)
        {
            Console.WriteLine($"\nYour new string is: {newString}\nPress enter to close the program.");
        }
    }
}
