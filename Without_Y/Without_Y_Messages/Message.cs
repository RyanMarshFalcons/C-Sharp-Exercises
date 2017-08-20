using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Y_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Without Y program where you will enter a string and thenI will remove any y or Ys at the begining and end or your string. Press enter tocontinue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input a series of characters to form your string: ");
        }

        public static void AtLeastOneCharacter()
        {
            Console.Write("\nYou must input at least one character to create a valid string. Please try\nagain: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nYour new string is: {newString}\nPress enter to close the program.");
        }
    }
}
