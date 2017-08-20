using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_To_End_3_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Left To End 3 program where you will enter a string and then I will form a new string by moving the first three characters to the end.\nPress enter to continue.");
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
