using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Longest_4_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my String Max 4 program. Enter four strings and I will tell you how\nmany characters the longest string has. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterString(int entryNum)
        {
            Console.Write($"\nPlease enter string number {entryNum}: ");
        }

        public static void NoEmptyStrings(int entryNum)
        {
            Console.Write($"\nSorry but your string cannot be empty. Please enter string number {entryNum}: ");
        }

        public static void DisplayLongest(int charCount)
        {
            Console.WriteLine($"\nThe longest string that you entered was you entered was {charCount.ToString("n0")} characters.\nPress enter to close the program.");
        }
    }
}
