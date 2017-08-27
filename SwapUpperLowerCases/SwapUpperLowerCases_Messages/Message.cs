using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapUpperLowerCases_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my to Swap Cases program where you enter text and I make\nyour lowercase text uppercase and your uppercase text lowercase. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input a series of letters, words, or phrases and I will swap their cases for you: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please try\nagain: ");
        }

        public static void DisplayResult(string userInput, string swappedCases)
        {
            Console.WriteLine($"\n{userInput} with cases swapped is {swappedCases}\nPress enter to close the program.");
        }

    }
}
