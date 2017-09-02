using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my String Manipulation program where you will enter a\nstring and then select how you want me to manipulate your string for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserString()
        {
            Console.Write("Please enter a series of characters to form your string: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must input at least four characters for your string to be valid. Please try\nagain: ");
        }

        public static void RequestManipulation()
        {
            Console.WriteLine("\nPlease select which manipulation you wish for me to perform on your string:\nA) Swap the first and the last characters of your string\nB) Add the first character to the front and the end of your string\nC) Add the last character to the front and the end of your string\nD) Add the middle character(s) to the front and the end of your string\nE) Make three copies of the first three characters of your string\nF) Make three copies of the last three characters of your string\nG) Make the first three characters of your string uppercase\nH) Make the last three characters of your string uppsercase\nI) Double every character in your string\nJ) Triple every character in your string\nK) Reverse your string\nL) Explode out your string\nM) Swap the upper and lower cases of your string\nN) Shift every third character past the next two characters of your string\n   ignoring extra characters at the end of the string if there are any");
        }

        public static void InvalidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Please select which\nmanipulation you wish for me to perform on your string:\nA) Swap the first and the last characters of your string\nB) Add the first character to the front and the end of your string\nC) Add the last character to the front and the end of your string\nD) Add the middle character(s) to the front and the end of your string\nE) Make three copies of the first three characters of your string\nF) Make three copies of the last three characters of your string\nG) Make the first three characters of your string uppercase\nH) Make the last three characters of your string uppsercase\nI) Double every character in your string\nJ) Triple every character in your string\nK) Reverse your string\nL) Explode out your string\nM) Swap the upper and lower cases of your string\nN) Shift every third character past the next two characters of your string\n   ignoring extra characters at the end of the string if there are any");
        }

        public static void DisplayResult(string newString, string typeOfManipulation)
        {
            Console.WriteLine($"\nAfter performing {typeOfManipulation} manipulation your string now reads as:\n{newString}\nPress enter to close the program.");
        }
    }
}
