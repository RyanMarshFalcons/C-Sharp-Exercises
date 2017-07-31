using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my number sorting program where you will enter a series of numbers and I will sort them for you. Press enter to continue.");
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
            Console.Write("\nWould you like to enter another number to be sorted? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void NumbersSortedBelow(int counter)
        {
            Console.WriteLine($"\nThe {counter} numbers that you entered have been sorted as follows: ");
        }
        
    }
}
