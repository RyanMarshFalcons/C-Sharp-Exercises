using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Number_Messages;

namespace Love_Number
{
    public class Utility
    {
        public int GetValidNumber(string firstSecondLove)
        {
            Message.EnterNumber(firstSecondLove);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, firstSecondLove);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfLoveNum(int num1, int num2, int loveNum)
        {
            return ((num1 == loveNum) || (num2 == loveNum));
        }

        public bool CheckIfSumIsLoveNum(int num1, int num2, int loveNum)
        {
            return num1 + num2 == loveNum;
        }

        public bool CheckIfDifferenceIsLoveNum(int num1, int num2, int loveNum)
        {
            return Math.Abs(num1 - num2) == loveNum || Math.Abs(num2 - num1) == loveNum;
        }

        public bool CheckIfProductIsLoveNum(int num1, int num2, int loveNum)
        {
            return num1 * num2 == loveNum;
        }

        public bool CheckIfQuotientIsLoveNum(int num1, int num2, int loveNum)
        {
            return ((num1 / num2 == loveNum) || (num2 / num1 == loveNum));
        }

        public void DisplayResults(bool doLoveNum, int loveNum)
        {
            if (doLoveNum)
            {
                Message.DoLoveNumber(loveNum);
            }
            else
            {
                Message.DoNotLoveNumber(loveNum);
            }
        }
    }
}
