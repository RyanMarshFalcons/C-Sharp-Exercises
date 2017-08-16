using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_And_Back_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Front And Back program where you will enter a string andthen I will swap the first and last characters for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Input at least two characters to form your string: ");
        }

        public static void AtLeastTwoCharacters()
        {
            Console.Write("\nSorry but you must input at least two characters to create a valid string.\nPlease try again: ");
        }

        public static void DisplayNewString (string newString)
        {
            Console.WriteLine($"\nAfter swapping the first and last characters of your old string your newly\nformed string is: {newString}\nPress enter to close the program.");
        }
    }
}
