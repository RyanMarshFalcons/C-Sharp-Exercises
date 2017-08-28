using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Block_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Max Count program where you will enter a string and thenI will calculate the largest block (run of adjacent identical characters) that\nthere are is your string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Enter a string of characters: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must enter at least one character to create a valid string. Please try\nagain: ");
        }

        public static void DisplayResult(int blockLength)
        {
            Console.WriteLine($"\nThe longest block of characters in your string is {blockLength} characters. Press enter\nto close the program.");
        }
    }
}
