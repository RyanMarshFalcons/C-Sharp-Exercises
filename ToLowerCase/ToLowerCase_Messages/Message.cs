using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerCase_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my to lower case program where you enter text and I make itall lowercase. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input a series of letters or words and I will make them all lowercase foryou: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me to be able to turn your input into all lowercase. Please try again: ");
        }

        public static void DisplayResult(string userInput, string allLowerCase)
        {
            Console.WriteLine($"\n{userInput} to all lowercase is {allLowerCase}");
        }
    }
}
