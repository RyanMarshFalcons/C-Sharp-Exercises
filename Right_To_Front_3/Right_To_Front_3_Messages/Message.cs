using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_To_Front_3_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Right To Front 3 program where you will enter a string\nand then I will form a new string by moving the last three characters to the\nfront. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input a series of characters to form your string: ");
        }

        public static void AtLeastFourCharacters()
        {
            Console.Write("\nYou must input at least four characters to create a valid string. Please try\nagain: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nYour new string is: {newString}\nPress enter to close the program.");
        }
    }
}
