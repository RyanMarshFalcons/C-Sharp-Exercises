using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_4_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Front 4 program where you will enter a string and then Iwill form a new string of four copies of the first four characters of your\nstring. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input at least four characters to form your string: ");
        }

        public static void AtLeastFour()
        {
            Console.Write("\nYou must input at least four characters to create a valid atring. Please try\nagain: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nThe Front 4 string that I formed from the first four letters of your string is: {newString}\nPress enter to close the program.");
        }
    }
}
