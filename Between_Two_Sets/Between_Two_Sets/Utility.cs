using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Between_Two_Sets_Messages;

namespace Between_Two_Sets
{
    public class Utility
    {
        public int GetValidNumber(int numberPlace, string firstSecond)
        {
            Message.InputNumber(numberPlace, firstSecond);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, numberPlace, firstSecond);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive(numberPlace, firstSecond);
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

        public List<int> CalculateBetween(int[] firstSet, int[] secondSet)
        {
            Array.Sort(firstSet);
            Array.Sort(secondSet);
            var numsBetween = new List<int>();
            var match = true;
            for (int i = firstSet[firstSet.Length - 1]; i <= secondSet[0]; i++)
            {
                match = true;
                foreach (var num in firstSet)
                {
                    if (i % num != 0)
                    {
                        match = false;
                    }
                }
                foreach (var num in secondSet)
                {
                    if (num % i != 0)
                    {
                        match = false;
                    }
                }
                if (match)
                {
                    numsBetween.Add(i);
                }
            }
            return numsBetween;
        }

        public void DisplayResults(List<int> numsBetween)
        {
            if (numsBetween.Count == 0)
            {
                Message.NoNumbersBetween();
            }
            else
            {
                Message.DisplayNumbersBetween(numsBetween, numsBetween.Count);
            }
        }
    }
}
