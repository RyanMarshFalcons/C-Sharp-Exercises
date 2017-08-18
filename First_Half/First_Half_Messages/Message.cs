using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Half_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my First Half program where you will input a string and I\nwill make a new string out of the first half of your string, if your string has an odd number of characters I will include the full character that is cut in\nhalf in the middle. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter a string of characters: ");
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
