using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Count_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Count Triple program where you will enter a string and\nthen I will count how many triples (characters appearing three times in a row)\nthat there are in your string. Triples can overlap so if a character appears\nfour times in a row it counts as two triples. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Enter a string of characters: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must enter at least three characters to create a valid string.\nPlease try again: ");
        }

        public static void FoundTriples(int tripleCount)
        {
            Console.WriteLine($"\nCongratulations you have {tripleCount} triples in your string!!! Press enter to close the\nprogram.");
        }

        public static void DidntFindTriples()
        {
            Console.WriteLine("\nUnfortunately you don't have any triples in your string. Press enter to close\nthe program.");
        }
    }
}
