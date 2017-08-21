using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moose_Horse_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Moose Horse program where you will enter a string and I\nwill tell you how many times the word \"moose\" and the word \"horse\" appear. Pressenter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input a string of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must input at least five characters for it to be a valid string. Please try\nagain: ");
        }

        public static void DisplayResult(int mooseCount, int horseCount)
        {
            Console.WriteLine($"\nThe word \"moose\" appeared {mooseCount} times and the word \"horse\" appeared {horseCount} times. Press\nenter to close the program.");
        }
    }
}
