using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_Front_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Repeat Front program where you will input a string and anumber n that I will use to make n repetitions of the first n characters of yourstring. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("\nPlease enter a string of characters: ");
        }

        public static void MustBeAtLeast1Character()
        {
            Console.Write("\nSorry but you must input at least two characters for me to be able to form a newstring for you. Please try again: ");
        }

        public static void EnterNumber()
        {
            Console.Write("\nPlease enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void NotValidNumber(string input, int lastIndex)
        {
            Console.Write($"\nSorry but {input} is not a valid number. Please input a number\nbetween 1 and {lastIndex}: ");
        }

        public static void DisplayResults(string newString)
        {
            Console.WriteLine($"\nYour new string is:\n{newString}\nPress enter to close the program.");
        }
    }
}
