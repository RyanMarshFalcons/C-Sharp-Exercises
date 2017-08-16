using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_Up_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Begin Up program where you will enter a string and then I will make the first three characters of your string upper case. Press enter tocontinue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Input at least three characters to form your string: ");
        }

        public static void AtLeastThreeCharacters()
        {
            Console.Write("\nSorry but you must input at least three characters to create a valid string.\nPlease try again: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nAfter making the beginning of your string uppercase your new string is now:\n{newString}\nPress enter to close the program.");
        }
    }
}
