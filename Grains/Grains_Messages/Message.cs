using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grains_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Grains program. There once was a wise servant who saved the life\nof a prince. The king promised to pay whatever the servant could dream up.\nKnowing that the king loved chess, the servant told the king he would like to\nhave grains of wheat. One grain on the first square of a chess board. Two grainson the next. Four on the third, and so on. In this program you will tell me how many squares on the chess board that you would like me to calculate the number\nof grains of wheat that the king would have to pay out. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write("Please enter the number of squares on the chess board that you would like me to calculate for: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number of squares on\nthe chess board that you would like me to calculate for: ");
        }

        public static void MustBePositive()
        {
            Console.Write($"\nSorry but the number of squares on the chess board must be positive. Please\nenter the number of squares on the chess board that you would like me to\ncalculate for: ");
        }

        public static void CannotBeGreaterThan64()
        {
            Console.Write("\nSorry but there are only 64 squares on a chess board so your number cannot be\ngreater than 64. Please enter the number of squares on the chess board that you would like me to calculate for: ");
        }

        public static void DisplayResults(int numSquares, string total)
        {
            Console.WriteLine($"\nThe total number of grains of wheat that the king would have to pay out for {numSquares}\nsquares on the chess board is {total} grains. Press enter to\nclose the program.");
        }

    }
}
