using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbol_Count_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my symbol count program where I will count the number of\nsymbols that you input. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input as many words, numbers, spaces, and symbols as you please and I\nwill tell you how many symbols there are: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me to perform a count of the\nsymbols. Please try again: ");
        }

        public static void DisplayCount(int count)
        {
            Console.WriteLine($"\nAccording to my calculations there are {count} symbols in your input.");
        }

    }
}
