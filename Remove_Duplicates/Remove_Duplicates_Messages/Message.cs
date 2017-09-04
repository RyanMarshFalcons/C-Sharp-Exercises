using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Remove Duplicates program where you will enter a string of\ncharacters and then select whether you want me to remove duplicate letters,\nduplicate numbers, or duplicate symbols from your string. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void RequestUserString()
        {
            Console.Write("Please input a series of characters: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please input a series of characters: ");
        }

        public static void RequestSelection()
        {
            Console.WriteLine("\nWould you like me to:\nA) Remove any duplicate letters\nB) Remove any duplicate numbers\nC) Remove any duplicate symbols");
        }

        public static void InvalidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is an invalid selection.\nWould you like me to:\nA) Remove any duplicate letters\nB) Remove any duplicate numbers\nC) Remove any duplicate symbols");
        }

        public static void DisplayNewString(string removedType, string newString)
        {
            Console.WriteLine($"\nAfter removing all the duplicate {removedType} in your string your new string is:\n{newString}\nPress enter to close the program.");
        }
    }
}
