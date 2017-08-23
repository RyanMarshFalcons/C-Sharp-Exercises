using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Sandwich_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Get Sandwich program where you will input a string and Iwill construct a sandwich between the first and last instances of the word\n\"bread\" in your string if at least two instances exist. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter a string of characters: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least eleven characters for me to be able to form a new string for you. Please try again: ");
        }

        public static void WasASandwich(string newString)
        {
            Console.WriteLine($"\nCongratulations I was able to construct the following sandwich:\n{newString}\nPress enter to close the program.");
        }

        public static void WasNotASandwich()
        {
            Console.WriteLine($"\nUnfortunately there were not two appearances of the word \"bread\" in your string so there was no sandwich. Press enter to close the program.");
        }
    }
}
