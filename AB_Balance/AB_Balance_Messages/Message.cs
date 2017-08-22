using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_Balance_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my AB Balance program where you will enter a string and I\nwill tell you whether or not your string has a balance of a's and b's in it.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input a string of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must input at least one character for it to be a valid string. Please try\nagain: ");
        }

        public static void WasABalance()
        {
            Console.WriteLine($"\nCongratulations there was an AB balance in your string!!! Press enter to close\nthe program.");
        }

        public static void WasNotABalance()
        {
            Console.WriteLine($"\nUnfortunately there was not an AB balance in your string. Press enter to close\nthe program.");
        }
    }
}
