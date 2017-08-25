using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Bricks_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Make Bricks program. You're about to start building a row of\nbricks with small (1 inch) medium (3 inches) and large (5 inches) bricks. Lets\nfind out if you have enough bricks to do so. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RowLength()
        {
            Console.Write("How many inches long is the row of bricks that you're about to build: ");
        }

        public static void MustHavePositiveLength()
        {
            Console.Write($"\nSorry but row length must be positive. Please input how many inches long the rowof bricks that you're about to build is: ");
        }

        public static void NumberOfBricks(string typeOfBrick)
        {
            Console.Write($"\nHow many {typeOfBrick} bricks do you have: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void CantBeNegativeNum(string typeOfBrick)
        {
            Console.Write($"\nSorry but you can't have a negative number of bricks, please input how many\n{typeOfBrick} bricks you have: ");
        }

        public static void HaveEnoughBricks(int rowLength)
        {
            Console.WriteLine($"\nCongratulations you can build a {rowLength} inch row of bricks with your collection of\nbricks!!!! Press enter to close the program.");
        }

        public static void DontHaveEnoughBricks(int rowLength)
        {
            Console.WriteLine($"\nUnfortunately you cannot build a {rowLength} inch row of bricks with your collection of\nbricks. Press enter to close the program.");
        }
    }
}
