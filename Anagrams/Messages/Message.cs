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
            Console.WriteLine("Welcome to my anagrams program. An anagram is a word or phrase that is formed byrearranging the letters of another word or phrase. \nPress enter to continue.");
            Console.ReadLine();
        }

        public static void RequestString(string firstOrSecond)
        {
            Console.Write($"\nPlease input your {firstOrSecond} word or phrase: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me to check whether or it is an\nanagram. Please try again: ");
        }

        public static void AreAnagrams(string firstInput, string secondInput)
        {
            Console.WriteLine($"\nCongratulations {firstInput} and {secondInput} are anagrams!");
        }

        public static void AreNotAnagrams(string firstInput, string secondInput)
        {
            Console.WriteLine($"\nI'm sorry but {firstInput} and {secondInput} are not anagrams.");
        }
    }
}
