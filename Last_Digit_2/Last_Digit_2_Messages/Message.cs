using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Digit_2_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Last Digit 2 program where you enter two numbers and I tell you\nwhether or not they have the same last digit. Press enter to continue.");
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
            Console.WriteLine($"\nCongratulations your two numbers have the same last digit!!!");
        }

        public static void DontMatch()
        {
            Console.WriteLine($"\nUnfortunately your two numbers do not have the same last digit.");
        }

    }
}