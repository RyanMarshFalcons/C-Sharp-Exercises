using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginning_Other_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Beginning Other program where you will enter two stringsand I will tell you whether or not one string is equal to the beginning of the\nother string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput(string firstSecond)
        {
            Console.Write($"\nPlease input the {firstSecond} string of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must input at least one character for it to be a valid string. Please try\nagain: ");
        }

        public static void MatchesTheBeginning(string shorterString, string longerString)
        {
            Console.WriteLine($"\nCongratulations the {shorterString} string you entered is equal to the beginning of the\n{longerString} string you entered. Press enter to close the program.");
        }

        public static void NoMatches()
        {
            Console.WriteLine("\nUnfortunately neither string you entered is equal to the beginning of the other\nstring. Press enter to close the program.");
        }

        public static void SameString()
        {
            Console.WriteLine("\nBoth strings that you entered are exactly the same matching eachother from\nbegining to end. Press enter to close the program.");
        }
    }
}
