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
            Console.Write("Please input a series of words and I will transform them into an acronym for \nyou: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least two characters for your string to be valid. Please try\nagain: ");
        }

        public static void NoWords()
        {
            Console.Write("\nYou must input at least one word for your string to be valid. Please try\nagain: ");
        }

        public static void DisplayResult(string userString, string acronym)
        {
            Console.WriteLine($"\n{userString} converts into the acronym {acronym}\nPress enter to close the program.");
        }

    }
}
