using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Dog_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Cat Dog program where you will enter a string and I willtell you how many times the word \"cat\" and the word \"dog\" appear. Press enter tocontinue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input a string of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must input at least three characters for it to be a valid string. Please tryagain: ");
        }

        public static void DisplayResult(int catCount, int dogCount)
        {
            Console.WriteLine($"\nThe word \"cat\" appeared {catCount} times and the word \"dog\" appeared {dogCount} times. Press\nenter to close the program.");
        }
    }
}
