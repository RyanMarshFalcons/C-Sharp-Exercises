using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Perfect Numbers program where you will enter a number and then I\nwill tell you whether your number is perfect, abundant, or deficient based on\nits aliquot sum. The aliquot sum is the sum of the factors of a number not\nincluding the number itself. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write("\nEnter your number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter your number: ");
        }

        public static void MustBePositive()
        {
            Console.Write($"\nSorry but your number must be positive. Please enter your number: ");
        }

        public static void DisplayResults(int userNum, string classification, int sum, string reason)
        {
            Console.WriteLine($"\nYour number is a {classification} number because the sum of its factors is {sum}\nwhich is {reason} your number {userNum}. Press enter to close the program.");
        }
    }
}
