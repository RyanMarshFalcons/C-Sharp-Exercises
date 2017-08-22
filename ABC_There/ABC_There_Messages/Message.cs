using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_There_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my ABC program where you will enter a string and I will\ntell you whether or not your string contains an appearance of \"abc\" or \"ABC\"\nwhere the appearance is not directly preceeded by a period (.). Press enter to\ncontinue.");
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

        public static void DisplayResult(int abcCount, int ABCCount)
        {
            Console.WriteLine($"\nThere were {abcCount} appearances of \"abc\" and {ABCCount} appearances of \"ABC\" that were not\npreceded by a period. Press enter to close the program.");
        }
    }
}
