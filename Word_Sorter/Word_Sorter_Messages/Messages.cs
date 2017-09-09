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
            Console.WriteLine("Hello and welcome to my Word Sorter program where you will enter a string and I will extract the words from your string and then sort them for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("\nPlease enter a string of characters: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please try\nagain: ");
        }

        public static void WordsSortedBelow(int counter)
        {
            Console.WriteLine($"\nThe {counter} words from your string have been sorted as follows:");
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Thank you for using my Word Sorter program. I hope that you enjoyed using it.\nPress enter to close the progam.");
            Console.ReadLine();
        }
    }
}
