using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_3_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Front 3 program where you will enter a string and then Iwill form a new string of three copies of the first three characters of your\nstring. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input at least three characters to form your string: ");
        }

        public static void AtLeastThree()
        {
            Console.Write("\nYou must input at least three characters to create a valid atring. Please try\nagain: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nThe Front 3 string that I formed from the first three letters of your string is:{newString}\nPress enter to close the program.");
        }
    }
}
