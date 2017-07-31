using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my letter sorting program where you will enter a series of letters and I will sort them for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterLetter()
        {
            Console.Write("\nPlease enter a letter: ");
        }

        public static void NotALetter(string input)
        {
            Console.Write($"\nSorry but {input} is not a letter. Please input a letter: ");
        }

        public static void AddAnotherLetter()
        {
            Console.Write("\nWould you like to enter another letter to be sorted? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void LettersSortedBelow(int counter)
        {
            Console.WriteLine($"\nThe {counter} letters that you entered have been sorted as follows: ");
        }

    }
}
