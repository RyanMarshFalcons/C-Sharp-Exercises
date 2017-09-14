using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Multiples_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Sum Of Multiples program where you will enter a ceiling number andthen as many other numbers as you please. Then I will calculate the sum of all\nthe multiples of the numbers that you entered up to but not including the\nceiling number. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(string theceilinga)
        {
            Console.Write($"\nEnter {theceilinga} number: ");
        }

        public static void NotANumber(string input, string theceilinga)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter {theceilinga} number: ");
        }

        public static void MustBePostive(string input, string theceilinga)
        {
            Console.Write($"\nSorry but {input} is not a positive number. Please enter {theceilinga} number: ");
        }

        public static void AddAnotherNumber()
        {
            Console.Write("\nWould you to enter another number? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void DisplaySum(int ceilingNum, int sum)
        {
            Console.WriteLine($"\nThe sum of the multilples of the numbers that you inputted that are less than\n{ceilingNum} is {sum}. Press enter to close the program.");
        }
    }
}
