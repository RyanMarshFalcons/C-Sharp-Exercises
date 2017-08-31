using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_By_30_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Less By 30 program where you will enter five numbers and I will\ntell you whether or not one of your numbers is at least thirty less than anotherone of your numbers. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumber(string entryNum)
        {
            Console.Write($"\nPlease enter the {entryNum} number: ");
        }

        public static void NotANumber(string input, string entryNum)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the {entryNum} number: ");
        }

        public static void IsLessByThirty(int count)
        {
            Console.WriteLine($"\n{count} of your numbers are at least thirty less than another one of your numbers.\nPress enter to close the program.");
        }

    }
}
