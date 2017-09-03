using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Count_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my String Count program where you will enter a string and\nthen I will count the number of letters, spaces, numbers, and symbols in your\nstring. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter a series of characters: ");
        }

        public static void TooShort()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please enter a series of characters: ");
        }

        public static void DisplayCounts(int letterCount, int numberCount, int spaceCount, int symbolCount)
        {
            Console.WriteLine($"\nAccording to my calculations your string contains:\n{letterCount} letters\n{numberCount} numbers\n{spaceCount} spaces\n{symbolCount} symbols\nPress enter to close the program.");
        }
    }
}
