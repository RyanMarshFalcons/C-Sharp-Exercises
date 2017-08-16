using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every_Fifth_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Every Fifth program where you will enter a string and\nthen I will make a new string from every fifth character of your string. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Input at least one character to form your string: ");
        }

        public static void AtLeastOneCharacter()
        {
            Console.Write("\nSorry but you must input at least one character to create a valid string. Pleasetry again: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nAfter forming a new string from every fifth character your new string is:\n{newString}\nPress enter to close the program.");
        }
    }
}
