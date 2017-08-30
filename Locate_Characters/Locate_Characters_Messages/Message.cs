using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locate_Characters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Check For Character program where you enter text and\nthen enter specific characters that you would like me to count the instances of in your string. Press enter to continue.");
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
            Console.Write($"\nSorry but {input} does not qualify as a single character. Please\ninput a single character: ");
        }

        public static void DisplayResults(char specificChar, int count)
        {
            Console.WriteLine($"\nYour string contains {count} instances of {specificChar}. Press enter to continue.");
        }

        public static void AddAnotherWord()
        {
            Console.Write("\nWould you like to search for another character in your string? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for using my locate characters program. I hope that you enjoyed it.\nPress enter to close the program.");
        }
    }
}
