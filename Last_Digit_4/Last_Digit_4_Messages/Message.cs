using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Digit_4_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Last Digit 4 program where you enter four numbers and I tell you\nwhether or not at least two of them have the same last digit. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write("\nEnter a number: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but the number cannot be negative. Please enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter a number: ");
        }

        public static void DoMatch()
        {
            Console.WriteLine($"\nCongratulations at least two of your four numbers have the same last digit!!!");
        }

        public static void DontMatch()
        {
            Console.WriteLine($"\nUnfortunately none of your four numbers have the same last digit.");
        }

    }
}