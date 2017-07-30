using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosine_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Cosine program. Enter a number and I will tell you what that\nnumber's cosine is. Press enter to contine.");
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

        
        public static void CosineOfNum(double num, double cosineOfNum)
        {
            Console.WriteLine($"\nThe cosine of {num} is {cosineOfNum}");
        }
    }
}
