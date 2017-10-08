using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Reduced_String_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Super Reduced String program where you will enter a string of\ncharacters and then I will keep reducing your string by deleting pairs of\nmatching adjacent characters until there are no pairs of matching adjacent\ncharacters left. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterUserString()
        {
            Console.Write("Please enter a string of characters that you would like me to super reduce for\nyou: ");
        }

        public static void UserStringNotLongEnough()
        {
            Console.Write("\nSorry but your string must be at least two characters long in order to be valid.Please enter a string of characters that you would like me to super reduce for\nyou: ");
        }

        public static void DisplaySuperReducedString(string superReducedString, int timesReduced)
        {
            Console.WriteLine($"\nAfter reducing your original string down {timesReduced} times your string now reads as:\n{superReducedString}\nPress enter to close the program.");
        }

        public static void StringUnableToBeReduced()
        {
            Console.WriteLine("\nUnfortunately I was unable to reduce your string down at all because there were no pairs of matching adjacent characters present in your string. Press enter to close the program.");
        }

        public static void StringReducedToNothing(int timesReduced)
        {
            Console.WriteLine($"\nAfter reducing your string down {timesReduced} times your string is now empty and has no\ncharacters remaining in it. Press enter to close the program.");
        }
    }
}
