using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference21_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Difference 21 program. Enter a number and I will tell you the\nabsolute difference between your number and the number 21, except if your numberis greater than 21 in which case I will double the difference. Press enter to\ncontine.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("Please enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void DifferenceTo21(int num, int difference)
        {
            Console.WriteLine($"\nThe difference of {num} and 21 is {difference}. Press enter to close the program.");
        }
    }
}
