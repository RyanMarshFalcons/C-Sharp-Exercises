using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_Sum_Pairs_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Divisible Sum Pairs program where you will enter a single number\nand then a list of numbers. Then I will calculate how many pairs of numbers'\nsums in your list are evenly divisible by the single number. Press enter to\ncontinue.");
            Console.ReadLine();
        }

        public static void AskForDivisibleNum()
        {
            Console.Write("Please enter the number that you would like to use to test pairs' sum's\ndivisibility with: ");
        }

        public static void DivisibleNumIsNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number that\nyou would like to use to test pairs' sum's divisibility with: ");
        }

        public static void DivisibleNumMustBeMoreThanOne()
        {
            Console.Write($"\nSorry but the divisible number must be greater than one. Please enter the numberthat you would like to use to test pairs' sum's divisibility with: ");
        }

        public static void AskForNumForList(int placementOfNumber)
        {
            Console.Write($"\nPlease enter entry {placementOfNumber} on your list of numbers: ");
        }

        public static void NumForListIsNotANumber(string input, int placementOfNumber)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter entry {placementOfNumber} on your\nlist of numbers: ");
        }

        public static void NumForListMustBePositive(int placementOfNumber)
        {
            Console.Write($"\nSorry but the numbers on your list must be positive. Please enter entry {placementOfNumber} on\nyour list of numbers: ");
        }

        public static void AskToAddAnotherNumberToList()
        {
            Console.Write("\nWould you to add another number to the list? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Would you to add another number to the\nlist? y/n: ");
        }

        public static void NoDivisibleSumPairs(int divisibleNum)
        {
            Console.WriteLine($"\nUnfortuantely there were no pairs of numbers on your list that had a sum evenly divisible by {divisibleNum}. Press enter to close the program.");
        }

        public static void DisplayDivisibleSumPairs(List<Tuple<int, int>> divisibleSumPairs, int divisibleNum)
        {
            Console.WriteLine($"\nCongratulations, the following pairs of numbers from your list have a sum that\nis evenly divisible by {divisibleNum}:");
            foreach (var sumPair in divisibleSumPairs)
            {
                Console.WriteLine($"{sumPair.Item1} and {sumPair.Item2}");
            }
            Console.WriteLine("\nPress enter to close the program.");
        }

    }
}
