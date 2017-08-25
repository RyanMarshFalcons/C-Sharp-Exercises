using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Round_Sum_Messages;

namespace Round_Sum
{
    public class Utility
    {
        public int GetValidNumber(string firstSecondThird)
        {
            Message.EnterNumber(firstSecondThird);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, firstSecondThird);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CannotBeNegative(firstSecondThird);
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

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public int RoundToNearestTen(int num)
        {
            if (num % 10 >= 5)
            {
                return num + 10 - num % 10;
            }
            else
            {
                return num - num % 10;
            }
        }

        public int SumOfNums(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    
    }
}
