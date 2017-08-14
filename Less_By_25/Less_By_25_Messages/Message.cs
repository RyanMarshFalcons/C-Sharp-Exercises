using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_By_25_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Less By 25 program where you will enter three numbers and I will\ntell you whether or not one of your numbers is at least twenty five less than\nanother one of your numbers. Press enter to contine.");
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

        public static void IsLessByTwentyFive(int count)
        {
            Console.WriteLine($"\n{count} of your numbers are at least twenty five less than another one of your\nnumbers. Press enter to close the program.");
        }
    }
}
