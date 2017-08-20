using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Concatenation_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Minimum Concatenation program where you will input two strings andI will make them both the same length before combining them. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void RequestString(string firstSecond)
        {
            Console.Write($"\nPlease input your {firstSecond} string: ");
        }

        public static void NotEnoughCharacters(string firstSecond)
        {
            Console.Write($"\nYou must input at least one character for it to be a valid string. Please input your {firstSecond} string: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nYour new string is: {newString}\nPress enter to close the program.");
        }
    }
}
