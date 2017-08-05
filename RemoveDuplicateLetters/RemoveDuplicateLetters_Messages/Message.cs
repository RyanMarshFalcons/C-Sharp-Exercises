using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateLetters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Remove Duplicate Letters program. Enter a series of letters and I will remove the duplicate letters for you. Press enter to contine.");
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
            Console.Write("\nWould you like to add another letter to the list? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void NewListBelow(int lettersRemoved)
        {
            Console.WriteLine($"\nAfter {lettersRemoved} entries were removed your revised list of letters is below:");
        }
    }
}
