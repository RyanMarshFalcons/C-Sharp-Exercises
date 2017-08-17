using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_Last_Digit_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Same Last Digit program where you will enter two numbers and I\nwill tell you whether or not they have the same last digit. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecond)
        {
            Console.Write($"\nPlease enter the {firstSecond} number: ");
        }

        public static void NotANumber(string input, string firstSecond)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the {firstSecond} number: ");
        }

        public static void AreTheSame(int digit)
        {
            Console.WriteLine($"\nCongratulations both your numbers have {digit} as their last digit!!! Press enter to\nclose the program.");
        }

        public static void AreNotTheSame(int digit1, int digit2)
        {
            Console.WriteLine($"\nUnfortunately your first number's last digit is {digit1} and your second number's last digit is {digit2} so your two numbers do not have the same last digit. Press enter to\nclose the program.");
        }
    }
}
