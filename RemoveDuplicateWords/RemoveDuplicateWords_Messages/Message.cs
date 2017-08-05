using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateWords_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Remove Duplicate Words program. Enter a series of words and I willremove the duplicate words for you. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterWord()
        {
            Console.Write("\nPlease enter a word: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nSorry but you must input at least one character for your entry to qualify as a\nword. Please input a word: ");
        }

        public static void NotAWord(string input)
        {
            Console.Write($"\nSorry but {input} is not a word. Please input a word: ");
        }

        public static void AddAnotherWord()
        {
            Console.Write("\nWould you like to add another word to the list? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void NewListBelow(int wordsRemoved)
        {
            Console.WriteLine($"\nAfter {wordsRemoved} entries were removed your revised list of words is below:");
        }
    }
}
