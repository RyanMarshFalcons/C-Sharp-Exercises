using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Two_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my One Two program where you will input a string and I willcreate a new string by shifting every third character starting with the first\npast the following two and ignoring any excess character(s) at the end. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter a string of characters: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least three characters for me to be able to form a\nnew string for you. Please try again: ");
        }

        public static void DisplayResult(string newString)
        {
            Console.WriteLine($"\nYour new string is: {newString}\nPress enter to close the program.");
        }
    }
}
