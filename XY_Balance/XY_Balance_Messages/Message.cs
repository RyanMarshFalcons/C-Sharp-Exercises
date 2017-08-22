using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY_Balance_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my XY Balance program where you will enter a string and I\nwill tell you whether or not your string has a balance of x's and y's in it.\nPress enter to continue.");
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

        public static void WasXYalance()
        {
            Console.WriteLine($"\nCongratulations there was an XY balance in your string!!! Press enter to close\nthe program.");
        }

        public static void WasNotXYalance()
        {
            Console.WriteLine($"\nUnfortunately there was not an XY balance in your string. Press enter to close\nthe program.");
        }
    }
}
