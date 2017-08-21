using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sine_Cosine_Tangent_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Sine Cosine Tangent program where you will enter a number and thenchoose whether you want me to tell you that number's sine, cosine, or tangent.\nPress enter to contine.");
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

        public static void EnterTrigFunction()
        {
            Console.WriteLine("\nPlease select a trigonomic function:\nA) Sine\nB) Cosine\nC) Tangent");
        }

        public static void NotATrigFunction(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nPlease select a trigonomic function:\nA) Sine\nB) Cosine\nC) Tangent");
        }

        public static void SineOfNum(double num, double sineOfNum)
        {
            Console.WriteLine($"\nThe sine of {num} is {sineOfNum}\nPress enter to close the program.");
        }

        public static void CosineOfNum(double num, double cosineOfNum)
        {
            Console.WriteLine($"\nThe cosine of {num} is {cosineOfNum}\nPress enter to close the program.");
        }

        public static void TangentOfNum(double num, double tangentOfNum)
        {
            Console.WriteLine($"\nThe cosine of {num} is {tangentOfNum}\nPress enter to close the program.");
        }
    }
}
