using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangent_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Tangent program. Enter a number and I will tell you what that\nnumber's tangent is. Press enter to contine.");
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


        public static void TangentOfNum(double num, double tangentOfNum)
        {
            Console.WriteLine($"\nThe tangent of {num} is {tangentOfNum}");
        }
    }
}
