using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference_Of_Squares;
using Difference_Of_Squares_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userNum = utility.GetNumberOfNaturalNums();
            var squareOfTheSum = utility.CalculateSquareOfTheSum(userNum);
            var sumOfTheSquares = utility.CalculateSumOfTheSquares(userNum);
            var difference = utility.CalculateDifference(squareOfTheSum, sumOfTheSquares);
            utility.DisplayResults(userNum, squareOfTheSum, sumOfTheSquares, difference);
            Console.ReadLine();
        }
    }
}
