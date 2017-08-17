using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Shortest_3_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my String Min 3 program. Enter three strings and I will tell you how many characters the shortest string has. Press enter to contine.");
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

        public static void DisplayShortest(int charCount)
        {
            Console.WriteLine($"\nThe shortest string that you entered was you entered was {charCount.ToString("n0")} characters.\nPress enter to close the program.");
        }
    }
}
