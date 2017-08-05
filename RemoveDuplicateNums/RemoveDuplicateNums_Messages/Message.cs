using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateNums_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Remove Duplicate Numbers program. Enter a series of numbers and I will remove the duplicate numbers for you. Press enter to contine.");
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
            Console.Write("\nWould you like to add another number to the list? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void NewListBelow(int numRemoved)
        {
            Console.WriteLine($"\nAfter {numRemoved} entries were removed your revised list of numbers is below:");
        }
    }
}
