using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_ABBA_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Make ABBA program where you will input two strings and Iwill make a new string out of your two strings in an ABBA format. Press enter tocontinue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("\nPlease enter a string of characters: ");
        }

        public static void MustBeAtLeast1Character()
        {
            Console.Write("\nSorry but you must input at least one character for me to be able to form a new string for you. Please try again: ");
        }

        public static void DisplayResults(string newString)
        {
            Console.WriteLine($"\nYour new string is {newString}. Press enter to close the program.");
        }
    }
}
