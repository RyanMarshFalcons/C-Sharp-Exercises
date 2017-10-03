using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Days_At_The_Movies_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Beautiful Days At The Movies program. You want to go to the movieswith Lily but she will only go with you on days that are beautiful. A beautiful day is one who's absolute value between itself and its reverse is evenly\ndivisible by the divisor. You will enter a range of days and the divisor and\nthen I will tell you which days if any within your range are beautiful. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void InputDay(string firstLast)
        {
            Console.Write($"\nPlease enter the number of days from now until the {firstLast} day in the range of\ndays that you want me to check: ");
        }

        public static void DayIsNotANumber(string input, string firstLast)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number of days\nfrom now until the {firstLast} day in the range of days that you want me to\ncheck: ");
        }

        public static void DayMustBePositive(string firstLast)
        {
            Console.Write($"\nSorry but the number of days from now must be positve. Please enter the number\nof days from now until the {firstLast} day in the range of days that you want me to\ncheck: ");
        }

        public static void LastDayMustBeGreater()
        {
            Console.WriteLine($"\nThe last day in the range of days must be greater than the first day in the\nrange of days. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputDivisor()
        {
            Console.Write("\nPlease enter the number you want to use as the divisor to determine whether or\nnot days in your range are beautiful: ");
        }

        public static void DivisorIsNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number you\nwant to use as the divisor to determine whether or not days in your range are\nbeautiful: ");
        }

        public static void DivisorMustBeGreaterThanOne()
        {
            Console.Write($"\nSorry but the divisor must be greater than one. Please enter the number you wantto use as the divisor to determine whether or not days in your range are\nbeautiful: ");
        }

        public static void WereNoBeautifulDays(int firstDay, int lastDay)
        {
            Console.WriteLine($"\nUnfortunately there are no beautiful days between {firstDay} days from now and {lastDay}\ndays from now. I guess that you'll have to find someone else besides Lily to go to the movies with. Press enter to close the program.");
        }

        public static void DisplayBeautifulDays(int firstDay, int lastDay, List<int> beautifulDays)
        {
            Console.WriteLine($"\nCongratulations there are {beautifulDays.Count} beautiful days between {firstDay} days from now and\n{lastDay} days from now that you can go to the movies with Lily on!!! I have listed\nthem below for your convenience:\n");
            foreach (var day in beautifulDays)
            {
                Console.WriteLine($"{day} days from now");
            }
            Console.WriteLine($"\nPress enter to close the program.");
        }
    }
}
