using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_A_Number_Messages
{
    public static class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my reverse a number program where you enter a number and I reverse it for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("Input a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void DisplayNumberInReverse(string num, string reversedNum)
        {
            Console.WriteLine($"\n{num} in reverse is: {reversedNum}");
        }
    }
}
