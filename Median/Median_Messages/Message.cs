using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Median Number program where you will enter a series of\nnumbers and I will then tell you what the median of those inputted numbers is.\nPress enter to continue.");
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

        public static void AddAnotherNum()
        {
            Console.Write("\nWould you like to input another number? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void OutputMedian(int counter, double median)
        {
            Console.WriteLine($"\nThe median of the {counter} numbers that you entered is: {median}\nPress enter to close the program.");
        }
    }
}
