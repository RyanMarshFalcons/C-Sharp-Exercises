using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Mod_5_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Max Mod 5 program where you enter two numbers and I tell you whichone of them is more powerful. The more powerful number is whichever number is\nlarger, unless they both have the same remainder when divided by 5. Press enter to continue.");
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

        public static void MorePowerful(int num)
        {
            Console.WriteLine($"\n{num} is the more powerful number. Press enter to close the program.");
        }

        public static void NeitherMorePowerful(int num)
        {
            Console.WriteLine($"\nNeither number is more powerful because they are both {num}. Press enter to\nclose the program.");
        }
    }
}
