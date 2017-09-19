using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queen_Attack_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Queen Attack program where you will enter the positions of two\nqueens on a chess board and I will tell you whether or not they are in position to attack one another. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(string color, string rightBottom)
        {
            Console.Write($"\nPlease enter how many squares from the {rightBottom} of the chess board the {color}\nQueen is: ");
        }

        public static void NotANumber(string input, string color, string rightBottom)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how many squares from the\n{rightBottom} of the chess board the {color} Queen is: ");
        }

        public static void MustBePositive(string color, string rightBottom)
        {
            Console.Write($"\nSorry but your number must be positive. Please enter how many squares from the\n{rightBottom} of the chess board the {color} Queen is: ");
        }

        public static void IsTooHigh(string color, string rightBottom)
        {
            Console.Write($"\nSorry but a chess board is only eight squares wide and eight squares long.\nPlease enter how many squares from the {rightBottom} of the chess board the {color}\nQueen is: ");
        }

        public static void SquareAlreadyOccupied(int squaresFromRight, int squaresFromBottom)
        {
            Console.Write($"\nSorry but the Black Queen already occupies the space of {squaresFromRight} squares from the\nright and {squaresFromBottom} squares from the bottom. You'll have to enter the White Queen's\ncoordinates again. Press enter to continue.");
            Console.ReadLine();
        }

        public static void ShareSameRow(int rowNumber)
        {
            Console.WriteLine($"\nCongratulations the queens are in a position to attack one another because they are both positioned on row number {rowNumber}!!! Press enter to close the program.");
        }

        public static void ShareSameColumn(int columnNumber)
        {
            Console.WriteLine($"\nCongratulations the queens are in a position to attack one another because they are both positioned on column number {columnNumber}!!! Press enter to close the program.");
        }

        public static void ShareSameDiagonal(int diagonalSpaces)
        {
            Console.WriteLine($"\nCongratulations the queens are in a position to attack one another because they are positioned {diagonalSpaces} spaces diagonal from one another!!! Press enter to close the\nprogram.");
        }

        public static void CannotAttack()
        {
            Console.WriteLine($"\nUnfortunately the queens are not in a position to attack one another because\nthey do not share the same row, column, or diagonal. Press enter to close the\nprogram.");
        }
    }
}
