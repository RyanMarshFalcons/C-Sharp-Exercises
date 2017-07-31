using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtraction_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Subtraction program where you will enter two numbers and I will\ntell you what the difference of those two numbers is. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("\nPlease enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void DisplayDifference(double num1, double num2, double difference)
        {
            Console.WriteLine($"\nThe difference of {num1} minus {num2} is {difference}");
        }
    }
}
