using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Middle_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Extra Middle program where you will input a string and Iwill make a string of three copies ofthe middle two characters or two copies of the middle three characters if the string has an odd number of characters. Pressenter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter a string of characters: ");
        }

        public static void MustBeAtLeast2Characters()
        {
            Console.Write("\nSorry but you must input at least two characters for me to be able to form a newstring for you. Please try again: ");
        }

        public static void DisplayResults(string newString)
        {
            Console.WriteLine($"\nYour new string is {newString}. Press enter to close the program.");
        }
    }
}
