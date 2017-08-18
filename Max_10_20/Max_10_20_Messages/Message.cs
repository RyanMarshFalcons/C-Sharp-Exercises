using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_10_20_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Max 10 20 program where you will enter two numbers and I will tellyou which one of them is more powerful. You are free to enter any numbers that\nyou please, however only numbers between 10 and 20 have any power. Press enter\nto continue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecond)
        {
            Console.Write($"\nPlease enter the {firstSecond} number: ");
        }

        public static void NotANumber(string input, string firstSecond)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the {firstSecond} number: ");
        }

        public static void NeitherHasPower(int num1, int num2)
        {
            Console.WriteLine($"\nNeither {num1} or {num2} has any power. Press enter to close the program.");
        }

        public static void EquallyPowerful(int num)
        {
            Console.WriteLine($"\nBoth numbers are equally powerful because they are both {num}. Press enter\nto close the program.");
        }

        public static void MorePowerful(int morePowerful, int lessPowerful)
        {
            Console.WriteLine($"\n{morePowerful} is more powerful than {lessPowerful}. Press enter to close the program.");
        }
    }
}
