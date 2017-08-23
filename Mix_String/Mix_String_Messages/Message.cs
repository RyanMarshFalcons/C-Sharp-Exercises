using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_String_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Mix String program where you will enter two strings and I will mix them together to create a new string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput(string firstSecond)
        {
            Console.Write($"\nPlease input the {firstSecond} string of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must input at least one character for it to be a valid string. Please try\nagain: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nAfter mixing your two strings together your new string is:\n{newString}\nPress enter to close the program.");
        }
    }
}
