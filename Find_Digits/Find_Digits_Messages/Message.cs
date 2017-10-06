using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Digits_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Find Digits program where you will enter a number and then I will calculate which of your number's digits evenly divide your number. Press enter\nto continue.");
            Console.ReadLine();
        }

        public static void EnterFindDigitsNumber()
        {
            Console.Write("Please enter the number that you would like me to calculate it's digits that\nevenly divide it: ");
        }

        public static void FindDigitsNumberNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number\nthat you would like me to calculate it's digits that evenly divide it: ");
        }

        public static void FindDigitsNumberMustBeAtLeastTen()
        {
            Console.Write("\nSorry but you your number must be at least ten. Please enter the number that youwould like me to calculate it's digits that evenly divide it: ");
        }

        public static void NoDigitsEvenlyDivide(int userNum)
        {
            Console.WriteLine($"\nUnfortunately none of the individual digits of {userNum} evenly divide {userNum}.\nPress enter to close the program.");
        }

        public static void DisplayEvenlyDividingDigits(int userNum, int[] divisibleDigits)
        {
            Console.WriteLine($"\nCongratulations the following digits of {userNum} evenly divide {userNum}:");
            foreach (var digit in divisibleDigits)
            {
                Console.WriteLine(digit);
            }
            Console.WriteLine("\nPress enter to close the program.");
        }
    }
}
