using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_Count_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Substring Count program where you will enter a string\nand a substring and then I will tell you how many times if any the substring\nappears in the string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput(string stringSubstring)
        {
            Console.Write($"\nPlease input the {stringSubstring}: ");
        }

        public static void NotEnoughCharacters(string stringSubstring)
        {
            Console.Write($"\nYou must input at least one character for it to be a valid string. Please input the {stringSubstring}: ");
        }

        public static void DisplayResult(int count)
        {
            Console.WriteLine($"\nYour substring appears {count} times in your string. Press enter to close the\nprogram.");
        }
    }
}
