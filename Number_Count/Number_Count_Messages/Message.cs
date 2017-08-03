using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Count_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my number count program where I will count the number of\nnumbers that you input. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input as many words, numbers, spaces, and symbols as you please and I\nwill tell you how many numbers there are: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me to perform a count of the\nnumbers. Please try again: ");
        }

        public static void DisplayCount(int count)
        {
            Console.WriteLine($"\nAccording to my calculations there are {count} numbers in your input.");
        }
    }
}
