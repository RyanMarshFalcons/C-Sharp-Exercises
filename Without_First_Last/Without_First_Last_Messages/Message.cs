using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_First_Last_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Without First Last program where you will input a stringand I will make a new string out of all of the characters except the first and\nlast of your string. Press enter to continue.");
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
