using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smaller_Number_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Smaller Number program where you enter two numbers and I tell you\nwhich one of them is smaller. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write("\nEnter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter a number: ");
        }

        public static void NumbersEqual(int num)
        {
            Console.WriteLine($"\nNeither number is the smaller number because both the numbers were {num}.\nPress enter to close the program.");
        }

        public static void SmallerNumber(int num)
        {
            Console.WriteLine($"\n{num} is the smaller number. Press enter to close the program.");
        }
    }
}
