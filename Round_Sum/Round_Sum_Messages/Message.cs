using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_Sum_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Round Sum program where you will enter three numbers and I will\nround each one of them up or down to the nearest 10 and then add all of them\ntogether. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecondThird)
        {
            Console.Write($"\nPlease input the {firstSecondThird} number: ");
        }

        public static void NotANumber(string input, string firstSecondThird)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {firstSecondThird} number: ");
        }

        public static void CannotBeNegative(string firstSecondThird)
        {
            Console.Write($"\nSorry but the number cannot be negative. Please input the {firstSecondThird} number: ");
        }

        public static void DisplayResult(int total)
        {
            Console.WriteLine($"\nThe sum of your rounded numbers is {total}. Press enter to close the program.");
        }
    }
}
