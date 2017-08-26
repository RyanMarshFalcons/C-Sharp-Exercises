using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Explosion_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my String Explosion program where you will enter a string\nand then I will form a new string by exploding out your string 1, 2, 3, etc.\ncharacters at a time. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input at least three characters to form your string: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least three characters to create a valid string. Please try\nagain: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nYour string exploded out is:\n{newString}\nPress enter to close the program.");
        }
    }
}
