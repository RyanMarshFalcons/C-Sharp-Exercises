using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForCharacter_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Check For Character program where you enter text and\nthen I check if that text contains a specific character for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input as much text as you please: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please try\nagain: ");
        }

        public static void RequestCharacter()
        {
            Console.Write("\nPlease input a single character: ");
        }

        public static void NotASingleCharacter(string input)
        {
            Console.Write($"\nSorry but {input} does not qualify as a single character. Please input a single\ncharacter: ");
        }

        public static void DisplayResults(string entireInput, char specificChar, int count)
        {
            Console.WriteLine($"\n{entireInput} contains {count} instances of {specificChar}. Press enter to close the program.");
        }

    }
}
