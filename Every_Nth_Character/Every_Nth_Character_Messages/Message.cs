using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every_Nth_Character_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Every Nth Character program where you will enter a\nstring and a number n and then I will make a new string from every nth characterstarting with the first character of your string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserString()
        {
            Console.Write("Enter a series of characters to form your string: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least three characters to create a valid string.\nPlease try again: ");
        }

        public static void InputNumber()
        {
            Console.Write("\nPlease enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter a number: ");
        }

        public static void OutOfRange(string input, int maxNum)
        {
            Console.Write($"\nSorry but {input} is out of range. Your number must be at least 2 and no more\nthan {maxNum}. Please enter a number: ");
        }

        public static void DisplayNewString(string newString, int num)
        {
            Console.WriteLine($"\nAfter forming a new string out of every {num} characters your new string is:\n{newString}\nPress enter to close the program.");
        }
    }
}
