using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_Separator_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Repeat Separator program where you will input two\nstrings and a number n that I will use to make n repetitions of your first\nstring with the second string separating each repetition. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void RequestUserInput(string firstSecond)
        {
            Console.Write($"\nPlease enter the {firstSecond} string of characters: ");
        }

        public static void MustBeAtLeast1Character()
        {
            Console.Write("\nSorry but you must input at least one character for me to be able to form a new string for you. Please try again: ");
        }

        public static void EnterNumber()
        {
            Console.Write("\nPlease enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void NotValidNumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a valid number. Please input a number\ngreater than 1: ");
        }

        public static void DisplayResults(string newString)
        {
            Console.WriteLine($"\nYour new string is:\n{newString}\nPress enter to close the program.");
        }
    }
}
