using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Pig Latin translator program where you will enter a string in\nEnglish and then I will translate that string into Pig Latin for you. Numbers\nand symbols other than the ' that appears in words like \"can't\" will be ignored.Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Enter your string in English: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please try\nagain: ");
        }

        public static void DisplayInPigLatin(string inputAsPigLatin)
        {
            Console.WriteLine($"\nYour string translated into pig Latin is:\n{inputAsPigLatin}\nPress enter to close the program.");
        }

    }
}
