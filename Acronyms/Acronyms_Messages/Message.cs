using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acronyms_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my acronym program. An acronym is an abbreviation formed\nfrom the initial letters of other words. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("\nPlease input a series of words and I will transform them into an acronym for \nyou: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least two characters for your string to be valid. Please try\nagain: ");
        }

        public static void NoWords()
        {
            Console.Write("\nYou must input at least one word for your string to be valid. Please try\nagain: ");
        }

        public static void DisplayAcronym(string userString, string acronym)
        {
            Console.WriteLine($"\n{userString} converts into the acronym {acronym}\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void AddAnotherAcronym()
        {
            Console.Write("Would you me to convert another string into an acronym for you? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void DisplayAllAcronyms()
        {
            Console.WriteLine("\nHere are all of the acronyms that you created this session:");
        }

        public static void ThankYou()
        {
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("\nThank you for using my Acronyms program. I hope that you enjoyed using it. Pressenter to close the program.");
        }
    }
}
