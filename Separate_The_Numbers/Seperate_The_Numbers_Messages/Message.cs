using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seperate_The_Numbers_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Separate The Numbers Program where you will enter a number and\nthen I will tell you whether or not it can be separated into a sequence of two\nor more positive integers without allowing leading zeroes to count or any digitsto be rearranged. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("Please enter the number that you would like me to attempt to separate for\nyou: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number\nthat you would like me to attempt to separate for you: ");
        }

        public static void NumberLessThanTwelve()
        {
            Console.Write("\nSorry but your number cannot be less than twelve. Please enter the number that\nyou would like me to attempt to separate for you: ");
        }

        public static void UnableToSeparateTheNumbers(string userNumAsString)
        {
            Console.WriteLine($"\nUnfortunately {userNumAsString} cannot be separated into a sequence of two or more\npositive integers. Press enter to close the program.");
        }

        public static void DisplaySeparatedNumbers(string userNumAsString, string separatedNumbersAsString)
        {
            Console.WriteLine($"\nCongratulations, I was able to separate {userNumAsString} into this sequence:\n{separatedNumbersAsString}\nPress enter to close the program.");
        }
    }
}
