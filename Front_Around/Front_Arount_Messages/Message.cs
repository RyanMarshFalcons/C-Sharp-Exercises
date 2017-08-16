using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_Around_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Front Around program where you will enter a string and\nthen I will add on the last character of your string to both the front and the\nback of your string. Press enter to continue.");
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
            Console.WriteLine($"\nAfter adding the last character front around your old string your new string is:{newString}\nPress enter to close the program.");
        }
    }
}
