using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_String_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Without String program where you enter a base string anda remove string and then I will remove all instances of the remove string from\nthe base string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput(string baseRemove)
        {
            Console.Write($"\nPlease enter the {baseRemove} string: ");
        }

        public static void NotLongEnough(string baseRemove)
        {
            Console.Write($"\nYou must input at least one character for your string to be valid. Please enter the {baseRemove} string: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nAfter removing all of the instances of the remove string from the base string\nyou are left with: {newString}\nPress enter to close the program.");
        }
    }
}
