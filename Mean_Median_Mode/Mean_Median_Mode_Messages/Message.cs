using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean_Median_Mode_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Mean Median Mode program where you will enter a series\nof numbers and I will then tell you what the mean, median, and mode(s) of those inputted numbers are. Press enter to continue.");
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

        public static void OutputMean(int counter, double mean)
        {
            Console.WriteLine($"\nThe mean of the {counter} numbers that you entered is: {mean}\nPress enter to see the median.");
            Console.ReadLine();
        }

        public static void OutputMedian(int counter, double median)
        {
            Console.WriteLine($"The median of the {counter} numbers that you entered is: {median}\nPress enter to see the meode.");
            Console.ReadLine();
        }

        public static void OutputMode(int counter)
        {
            Console.WriteLine($"The mode(s) of the {counter} numbers that you entered are:");
        }

        public static void CloseProgram()
        {
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Thank you for using my Mean Median Mode program. I hope that you enjoyed using\nit. Press enter to close the program.");
            Console.ReadLine();
        }
    }
}
