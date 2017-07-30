using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubed_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Cubed program. Enter a number and I will tell you what that numbercubed is.\nPress enter to contine.");
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

        public static void NumberCubed(int num, int numSquared)
        {
            Console.WriteLine($"\n{num} cubed is {numSquared}.");
        }
    }
}
