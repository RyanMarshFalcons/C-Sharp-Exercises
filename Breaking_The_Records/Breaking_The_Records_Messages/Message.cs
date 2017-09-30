using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaking_The_Records_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Breaking The Records program where you just finished a season of\nbasketball and want to find out how many times you broke your personal records\nof most points scored in a game and least points scored in a game this season.\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void AskNumberOfGames()
        {
            Console.Write("How many games did your team play this season: ");
        }

        public static void NumberOfGamesIsNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. How many games did your team\nplay this season: ");
        }

        public static void MustBePositive()
        {
            Console.Write($"\nSorry but the number of games that your team played must be positive. How many\ngames did your team play this season: ");
        }

        public static void AskNumberOfPoints(int gameNumber)
        {
            Console.Write($"\nHow many points did you score in game number {gameNumber}: ");
        }

        public static void NumberOfPointsIsNotANumber(string input, int gameNumber)
        {
            Console.Write($"\nSorry but {input} is not a number. How many points did you score in\ngame number {gameNumber}: ");
        }

        public static void CannotBeNegative(int gameNumber)
        {
            Console.Write($"\nSorry but the number of points that you score in a game cannot be negative. How many points did you score in game number {gameNumber}: ");
        }

        public static void DisplayResults(int numGames, int timesSetLeastPoints, int timesSetMostPoints)
        {
            Console.WriteLine($"\nCongratulations, over the course of a {numGames} game season you broke your personal\nrecord of least points scored {timesSetLeastPoints} times and your personal record of most points\nscored {timesSetMostPoints} times!!! Press enter to close the program.");
        }
    }
}
