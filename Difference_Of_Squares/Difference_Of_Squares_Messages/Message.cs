using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Of_Squares_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Difference Of Squares program where you will enter a number N and I will you the difference between the square of the sum of the first N natural\nnumbers and the sum of the squares of the first N natural numbers. Press enter\nto continue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write("Please enter how much many of the first N natural numbers that you want me to\ncheck what the difference between the square of their sums and the sum of their squares is: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how much many of the first\nN natural numbers that you want me to check what the difference between the\nsquare of their sums and the sum of their squares is: ");
        }

        public static void MustBeGreaterThanOne()
        {
            Console.Write($"\nSorry but your number must be greater than one. Please enter how much many of\nthe first N natural numbers that you want me to check what the difference\nbetween the square of their sums and the sum of their squares is: ");
        }

        public static void MustBeLessThanTwoHundred()
        {
            Console.Write("\nSorry but your number must be less than two hundred. Please enter how much many of the first N natural numbers that you want me to check what the difference\nbetween the square of their sums and the sum of their squares is: ");
        }

        public static void DisplayResult(int userNum, string squareOfTheSum, string sumOfTheSquares, string difference)
        {
            Console.WriteLine($"\nThe square of the sum of the first {userNum} natural numbers is {squareOfTheSum} which is\n{difference} greater than the sum of the squares of the first {userNum} natural\nnumbers, {sumOfTheSquares}. Press enter to close the program.");
        }
    }
}
