using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isogram_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Isogram program. An isogram is a word or phrase that does not\nreuse any letters of the alphabet. You will enter a string and then I will tell you whether or not it is an isogram. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Please enter a string of characters: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please try\nagain: ");
        }

        public static void NoLetters()
        {
            Console.Write("\nYou must input at least one letter for your string to be valid. Please try\nagain: ");
        }

        public static void IsAnIsogram()
        {
            Console.WriteLine("\nCongratulations your string is an isogram!!! Press enter to close the program.");
        }

        public static void IsNotAnIsogram()
        {
            Console.WriteLine("\nUnfortunately your string is not an isogram. Press enter to close the program.");
        }
    }
}
