using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my pig Latin translator program. Enter a word in English and I will\ntranslate that word into pig Latin for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterWord()
        {
            Console.Write("Enter your word in English: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nSorry but you must input at least one character for your entry to qualify as a\nword. Please input a word: ");
        }

        public static void NoSpaces()
        {
            Console.Write("\nSorry but no spaces are allowed within a word in the English language. Please input a word: ");
        }

        public static void MustBeignWithALetter()
        {
            Console.Write("\nSorry but in the English language a word must begin with a letter. Please input a word: ");
        }

        public static void DisplayInPigLatin(string input, string inputAsPigLatin)
        {
            Console.WriteLine($"\n{input} translated into pig Latin is {inputAsPigLatin}.\nPress enter to close the program.");
        }

    }
}
