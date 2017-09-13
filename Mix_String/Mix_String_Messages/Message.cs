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
            Console.WriteLine("Hello and welcome to my Mix String program where you will enter multiple stringsand then I will mix them together for you to create a new string. Each string\nyou input will be equally represented in your new string so any additional\ncharacters in strings longer than the shortest string will be ignored. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserString()
        {
            Console.Write($"\nPlease enter a string of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must enter at least one character for it to be a valid string. Please enter a string of characters: ");
        }

        public static void AddAnotherString()
        {
            Console.Write("\nWould you to enter another string to be mixed? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nAfter mixing all your strings together your new string is:\n{newString}\nPress enter to close the program.");
        }
    }
}
