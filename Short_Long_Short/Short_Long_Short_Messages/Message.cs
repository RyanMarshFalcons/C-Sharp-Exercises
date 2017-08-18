using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Long_Short_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Short Long Short program where you will input two\nstrings and I will make a new string out of them in a short long short pattern. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput(string firstSecond)
        {
            Console.Write($"\nPlease enter a string of characters for the {firstSecond} string: ");
        }

        public static void MustBeAtLeast1Character()
        {
            Console.Write("\nSorry but you must input at least one character for me to be able to form a new string for you. Please try again: ");
        }

        public static void CannotBeSameLength()
        {
            Console.WriteLine("\nSorry but the two strings cannot be the same length. Press enter to contiue.");
            Console.ReadLine();
        }

        public static void DisplayResults(string newString)
        {
            Console.WriteLine($"\nYour new string is {newString}. Press enter to close the program.");
        }
    }
}
