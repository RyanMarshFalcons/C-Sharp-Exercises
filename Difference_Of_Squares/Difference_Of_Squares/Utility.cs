using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference_Of_Squares_Messages;

namespace Difference_Of_Squares
{
    public class Utility
    {
        public int GetNumberOfNaturalNums()
        {
            Message.InputNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (CheckIfGreaterThanOne(input) == false)
                    {
                        Message.MustBeGreaterThanOne();
                    }
                    else if (CheckIfLessThanTwoHundred(input) == false)
                    {
                        Message.MustBeLessThanTwoHundred();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfGreaterThanOne(string input)
        {
            return int.Parse(input) > 1;
        }

        public bool CheckIfLessThanTwoHundred(string input)
        {
            return int.Parse(input) < 200;
        }

        public int CalculateSquareOfTheSum(int userNum)
        {
            var sum = 0;
            for (int i = 1; i < userNum + 1; i++)
            {
                sum += i;
            }
            return sum * sum;
        }

        public int CalculateSumOfTheSquares(int userNum)
        {
            var sum = 0;
            for (int i = 1; i < userNum + 1; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        public int CalculateDifference(int squareOfTheSum, int sumOfTheSquares)
        {
            return squareOfTheSum - sumOfTheSquares;
        }

        public void DisplayResults(int userNum, int squareOfTheSum, int sumOfTheSquares, int difference)
        {
            Message.DisplayResult(userNum, AddCommasToNumber(squareOfTheSum), AddCommasToNumber(sumOfTheSquares), AddCommasToNumber(difference));
        }
        

        public string AddCommasToNumber(int num)
        {
            return String.Format("{0:n0}", num);
        }
    }
}
