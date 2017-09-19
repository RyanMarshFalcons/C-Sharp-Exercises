using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spelled_Out_Messages;

namespace Spelled_Out
{
    public class Utility
    {
        public int GetValidNumber()
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
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive();
                    }
                    else if (CheckIfTooHigh(input))
                    {
                        Message.IsTooHigh();
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

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool CheckIfTooHigh(string input)
        {
            return int.Parse(input) > 999999999;
        }

        public int[] ConvertNumToIntArray(int userNum)
        {
            var userNumAsString = userNum.ToString();
            while (userNumAsString.Length != 9)
            {
                userNumAsString = "0" + userNumAsString;
            }
            var userNumAsArray = new int[9];
            for (int i = 0; i < userNumAsString.Length; i++)
            {
                userNumAsArray[i] = int.Parse(userNumAsString[i].ToString());
            }
            return userNumAsArray;
        }

        public string SpellOutNumber(int[] userNumAsArray)
        {
            var spelledOutNum = "";
            if (!(userNumAsArray[0] == 0 && userNumAsArray[1] == 0 && userNumAsArray[2] == 0))
            {
                spelledOutNum += ConvertThreeDigits(new int[] { userNumAsArray[0], userNumAsArray[1], userNumAsArray[2] }) + "million ";
            }
            if (!(userNumAsArray[3] == 0 && userNumAsArray[4] == 0 && userNumAsArray[5] == 0))
            {
                spelledOutNum += ConvertThreeDigits(new int[] { userNumAsArray[3], userNumAsArray[4], userNumAsArray[5] }) + "thousand ";
            }
            spelledOutNum += ConvertThreeDigits(new int[] { userNumAsArray[6], userNumAsArray[7], userNumAsArray[8] });
            return spelledOutNum.Substring(0, spelledOutNum.Length - 1);
        }

        public string ConvertThreeDigits(int[] threeDigitNum)
        {
            var OnesToStringDict = new Dictionary<int, string>()
                {
                    {1, "one"},
                    {2, "two"},
                    {3, "three"},
                    {4, "four"},
                    {5, "five"},
                    {6, "six"},
                    {7, "seven"},
                    {8, "eight"},
                    {9, "nine"}
                };
            var TeenToStringDict = new Dictionary<int, string>()
                {
                    {0, "ten"},
                    {1, "eleven"},
                    {2, "twelve"},
                    {3, "thirteen"},
                    {4, "fourteen"},
                    {5, "fifteen"},
                    {6, "sixteen"},
                    {7, "seventeen"},
                    {8, "eighteen"},
                    {9, "nineteen"}
                };
            var TensToStringDict = new Dictionary<int, string>()
                {
                    {2, "twenty"},
                    {3, "thirty"},
                    {4, "forty"},
                    {5, "fifty"},
                    {6, "sixty"},
                    {7, "seventy"},
                    {8, "eighty"},
                    {9, "ninety"}
                };
            var spelledOutSection = "";
            if (threeDigitNum[0] != 0)
            {
                spelledOutSection += OnesToStringDict[threeDigitNum[0]] + " hundred ";
            }
            if (threeDigitNum[1] != 0)
            {
                if (threeDigitNum[1] == 1)
                {
                    spelledOutSection += TeenToStringDict[threeDigitNum[2]] + " ";
                }
                else
                {
                    spelledOutSection += TensToStringDict[threeDigitNum[1]] + " ";
                }
            }
            if (threeDigitNum[2] != 0 && threeDigitNum[1] != 1)
            {
                spelledOutSection += OnesToStringDict[threeDigitNum[2]] + " ";
            }
            return spelledOutSection;
        }
    }
}
