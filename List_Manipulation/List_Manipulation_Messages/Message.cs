using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulation_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my List Manipulation program where you will enter as many\nstrings as you please and then select how you want me to manipulate your stringsfor you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserString(int stringNumber)
        {
            Console.Write($"\nPlease enter string number {stringNumber}: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least one character for your string to be valid. Please try\nagain: ");
        }

        public static void AddAnotherString()
        {
            Console.Write("\nWould you to add another string to the list? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void DisplayListOfUnmanipulatedStrings()
        {
            Console.WriteLine("\nHere is your list of strings before they have been manipulated:");
        }

        public static void RequestManipulation()
        {
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Please select which manipulation you wish for me to perform on your strings:\nA) Add a letter to the beginning of your strings\nB) Add a letter to the end of your strings\nC) Capitalize all the letters in your strings\nD) Delete all strings that are less than a certain length\nE) Delete all strings that are more than a certain length\nF) Add a number to the beginning of your strings\nG) Add a number to the end of each strings\nH) Add a dollar sign to the begining of your strings\nI) Add an exclamation point to the end of your strings");
        }

        public static void InvalidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nPlease select which manipulation you wish for me to perform on your strings:\nA) Add a letter to the beginning of your strings\nB) Add a letter to the end of your strings\nC) Capitalize all the letters in your strings\nD) Delete all strings that are less than a certain length\nE) Delete all strings that are more than a certain length\nF) Add a number to the beginning of your strings\nG) Add a number to the end of each strings\nH) Add a dollar sign to the begining of your strings\nI) Add an exclamation point to the end of your strings");
        }

        public static void AddLetter(string beginningEnd)
        {
            Console.Write($"\nWhat letter would you like to add to the {beginningEnd} of your strings: ");
        }

        public static void RemoveStrings(string minimumMaximum)
        {
            Console.Write($"\nWhat is the {minimumMaximum} number of characters that you want the strings you keep to\nhave: ");
        }

        public static void AddNumber(string beginningEnd)
        {
            Console.Write($"\nWhat number would you like to add to the {beginningEnd} of your strings: ");
        }

        public static void NotALetter(string input, string beginningEnd)
        {
            Console.Write($"\nSorry but {input} is not a letter. What letter would you like\nto add to the {beginningEnd} your strings: ");
        }

        public static void NotANumber(string input, string beginningEnd)
        {
            Console.Write($"\nSorry but {input} is not a number. What number would you like\nto add to the {beginningEnd} of your strings: ");
        }

        public static void InvalidLength(string input, string minimumMaximum)
        {
            Console.Write($"\nSorry but {input} characters is not a valid length of a string. What\nis the {minimumMaximum} number of characters that you want the strings you keep to\nhave: ");
        }

        public static void DisplayListOfManipulatedStrings(string typeOfManipulation)
        {
            Console.WriteLine($"\nAfter performing {typeOfManipulation} manipulation on your strings your\nlist of strings now reads as:");
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Thank you for using my List Manipulation program. I hope that you enjoyed using it. Press enter to close the program.");
        }
    }
}
