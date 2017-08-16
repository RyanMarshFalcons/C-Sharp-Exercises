using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del_del_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Del del program where you will enter a string and then Iwill delete everything following the letters del or the letters Del including\ndel or Del themselves. Press enter to continue.");
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

        public static void StringUnchanged(string userString)
        {
            Console.WriteLine($"\nThere were no instances in your string of either del or Del so your string is\nstill: {userString}\nPress enter to close the program.");
        }

        public static void DisplayNewString(string newString, int charsDeleted)
        {
            Console.WriteLine($"\nAfter deleting {charsDeleted} characters from your old string your new string is now:\n{newString}\nPress enter to close the program.");
        }
    }
}
