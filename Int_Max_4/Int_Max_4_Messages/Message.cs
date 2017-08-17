using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_Max_4_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Int Max 4 program. Enter four numbers and I will tell you what\nthe largest number is. Press enter to contine.");
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

        public static void DisplayHighest(int num)
        {
            Console.WriteLine($"\nThe largest number you entered was {num.ToString("n0")}. Press enter to close the program.");
        }
    }
}
