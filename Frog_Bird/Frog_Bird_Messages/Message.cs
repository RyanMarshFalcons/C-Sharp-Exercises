using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frog_Bird_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Frog Bird program where you will enter a string and I\nwill tell you how many times the word \"frog\" and the word \"bird\" appear. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input a string of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must input at least four characters for it to be a valid string. Please try\nagain: ");
        }

        public static void DisplayResult(int frogCount, int birdCount)
        {
            Console.WriteLine($"\nThe word \"frog\" appeared {frogCount} times and the word \"bird\" appeared {birdCount} times. Press\nenter to close the program.");
        }
    }
}
