using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Mode Number program where you will enter a series of\nnumbers and then I will tell you what the mode of those inputted numbers is. If two or more of your numbers appear an equally most frequent number of times thenthere will be multiple modes. Press enter to continue.");
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

        public static void OutputMode(int counter)
        {
            Console.WriteLine($"\nThe mode(s) of the {counter} numbers that you entered is:");
        }

        public static void CloseProgram()
        {
            Console.WriteLine("\nThank you for using my mode program. I hope that you enjoyed using it. Press\nenter to close the program.");
            Console.ReadLine();
        }
    }
}
