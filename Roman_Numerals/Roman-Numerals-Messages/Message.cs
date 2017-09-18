using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.Write("Welcome to my Roman Numerals program where you will enter an arabic number and Iwill translate your number into Roman Numerals for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write($"Please input the the arabic number that you would like me to translate to Roman numerals for you: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the the arabic number\nthat you would like me to translate to Roman numerals for you: ");
        }

        public static void MustBePositive()
        {
            Console.Write($"\nSorry but your number must be positive. Please input the the arabic number that you would like me to translate to Roman numerals for you: ");
        }
        
        public static void IsTooHigh()
        {
            Console.Write("\nSorry but the Romans didn't count past 3,999. Please input the the arabic numberthat you would like me to translate to Roman numerals for you: ");
        }

        public static void DisplayResults(int ArabicNumber, string userNumAsRomanNumeral)
        {
            Console.WriteLine($"\n{ArabicNumber} as a Roman Numeral your number is {userNumAsRomanNumeral}");
        }
    }
}
