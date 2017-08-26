using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone_Sum_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Lone Sum program where you will enter three numbers and then I\nwill tell you what their sum is. However, if a number matches another number\nthat you input than that number does not count towards the sum. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecondThird)
        {
            Console.Write($"\nPlease enter the {firstSecondThird} number: ");
        }

        public static void NotANumber(string input, string firstSecondThird)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {firstSecondThird} number: ");
        }

        public static void DisplaySum(int num1, int num2, int num3, int sum)
        {
            Console.WriteLine($"\nThe sum of {num1}, {num2}, and {num3} is {sum}. Press enter to close the program.");
        }
    }
}
