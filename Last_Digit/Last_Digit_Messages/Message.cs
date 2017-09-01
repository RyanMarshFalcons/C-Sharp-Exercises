using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Digit_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Last Digit program where you will enter five numbers and I then I will tell you whether or not at least two of them have the same last digit.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(string whichNum)
        {
            Console.Write($"\nEnter the {whichNum} number: ");
        }

        public static void CantBeNegative(string whichNum)
        {
            Console.Write($"\nSorry but the number cannot be negative. Please enter the {whichNum} number: ");
        }

        public static void NotANumber(string input, string whichNum)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the {whichNum} number: ");
        }

        public static void DoMatch()
        {
            Console.WriteLine($"\nCongratulations at least two of your five numbers have the same last digit!!!\nPress enter to close the program.");
        }

        public static void DontMatch()
        {
            Console.WriteLine($"\nUnfortunately none of your five numbers have the same last digit. Press enter toclose the program.");
        }
    }
}
