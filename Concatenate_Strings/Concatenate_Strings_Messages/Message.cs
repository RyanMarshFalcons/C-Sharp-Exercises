using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Strings_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my concatenate strings program where you will enter two words or\nphrases and I will combine them for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestString(string firstOrSecond)
        {
            Console.Write($"\nPlease input your {firstOrSecond} word or phrase: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me combine your phrases properly.\nPlease try again: ");
        }

        public static void DisplayResult(string firstInput, string secondInput, string combinedInput)
        {
            Console.WriteLine($"\nThe concatenated strings of {firstInput} and {secondInput} are:\n{combinedInput}");
        }
    }
}
