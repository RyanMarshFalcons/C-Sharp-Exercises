using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evenly_Spaced_Messages;

namespace Evenly_Spaced
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
        
        public int[] SortNums(int[] nums)
        {
            Array.Sort(nums);
            return nums;
        }

        public int GetDifference(int num1, int num2)
        {
            return num2 - num1;
        }
        public bool CheckIfEvenlySpaced(int difference1, int difference2)
        {
            return difference1 == difference2;
        }

        public void DisplayResults(bool areEvenlySpaced, int num1, int num2, int num3, int space1, int space2)
        {
            if (areEvenlySpaced)
            {
                Message.AreEvenlySpaced(num1, num2, num3, space1);
            }
            else
            {
                Message.AreNotEvenlySpaced(num1, num2, num3, space1, space2);
            }
        }
    }
}
