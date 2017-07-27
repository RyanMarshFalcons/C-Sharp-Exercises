using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Sorter_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my word sorting program where you will enter a series of words and I will sort them for you.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void EnterWord()
        {
            Console.Write("\nPlease enter a word: ");
        }

        public static void NotAWord(string input)
        {
            Console.Write($"\nSorry but {input} is not a word. Please input a word: ");
        }

        public static void AddAnotherWord()
        {
            Console.Write("\nWould you like to enter another word to be sorted? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void WordsSortedBelow(int counter)
        {
            Console.WriteLine($"\nThe {counter} words that you entered have been sorted as follows: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nSorry but you must input at least one character for your entry to qualify as a\nword. Please input a word: ");
        }
    }
}
