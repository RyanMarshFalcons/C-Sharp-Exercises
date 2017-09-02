using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Meaning_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Name Meaning program where you will enter your name and then I will tell you what adjectives describe the letters in your name. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter your name: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your name to be valid. Please enter\nyour name: ");
        }

        public static void DoesNotContainLetter()
        {
            Console.Write("\nYour name must include at least one letter for your name to be valid. Please\nenter your name: ");
        }

        public static void DisplayResult(string userName)
        {
            Console.WriteLine($"\nThe following adjectives describe your name {userName}:");
        }

        public static void CloseProgram()
        {
            Console.WriteLine("\nPress enter to close the program.");
            Console.ReadLine();
        }
    }
}
