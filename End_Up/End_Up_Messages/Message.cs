using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End_Up_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my End Up program where you will enter a string and then I will make the last three characters of your string uppper case. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Input at least three characters to form your string: ");
        }

        public static void AtLeastThreeCharacters()
        {
            Console.Write("\nSorry but you must input at least three characters to create a valid atring.\nPlease try again: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nAfter making the ending of your string uppercase your new string is now:\n{newString}\nPress enter to close the program.");
        }
    }
}
