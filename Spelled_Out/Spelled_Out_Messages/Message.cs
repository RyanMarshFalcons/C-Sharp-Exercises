using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelled_Out_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.Write("Welcome to my Spelled Out program where you will enter a number and I will spellout your number in words for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write($"\nPlease input the number that you would like me to spell out for you: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the number that you\nwould like me to spell out for you: ");
        }

        public static void MustBePositive()
        {
            Console.Write($"\nSorry but your number must be positive. Please input the number that you would\nlike me to spell out for you: ");
        }

        public static void IsTooHigh()
        {
            Console.Write("\nSorry but your number must be less than a billion. Please input the number that you would like me to spell out for you: ");
        }

        public static void DisplayResults(int userNum, string userNumSpelledOut)
        {
            Console.WriteLine($"\n{userNum} spelled out is:\n{userNumSpelledOut}\nPress enter to close the program.");
        }
    }
}
