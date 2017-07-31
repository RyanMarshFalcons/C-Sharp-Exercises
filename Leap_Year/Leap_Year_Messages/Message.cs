using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Leap Year program. Enter a year and I will tell you whether that\nyear is a leap year or not. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterYear()
        {
            Console.Write("Please enter a year: ");
        }

        public static void NotAYear(string input)
        {
            Console.Write($"\nSorry but {input} is not a year. Please input a year: ");
        }

        public static void NotALeapYear(int year)
        {
            Console.WriteLine($"\n{year} is not a leap year.");
        }

        public static void IsALeapYear(int year)
        {
            Console.WriteLine($"\n{year} is a leap year.");
        }
    }
}
