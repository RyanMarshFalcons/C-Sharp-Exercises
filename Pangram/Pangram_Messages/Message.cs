using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Pangram program. A pangram is a sentence that uses every letter ofthe alphabet at least once. You will enter a string and then I will tell you\nwhether or not it is a pangram. Press enter to continue.");
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

        public static void IsAPangram()
        {
            Console.WriteLine("\nCongratulations your string is a pangram!!! Press enter to close the program.");
        }

        public static void IsNotAPangram()
        {
            Console.WriteLine("\nUnfortunately your string is not a pangram. Press enter to close the program.");
        }
    }
}
