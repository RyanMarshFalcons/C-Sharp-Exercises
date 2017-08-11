using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference63_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Difference 63 program. Enter a number and I will tell you the\nabsolute difference between your number and the number 63, except if your numberis greater than 63 in which case I will double the difference. Press enter to\ncontinue.");
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

        public static void DifferenceTo63(int num, int difference)
        {
            Console.WriteLine($"\nThe difference of {num} and 63 is {difference}. Press enter to close the program.");
        }
    }
}
