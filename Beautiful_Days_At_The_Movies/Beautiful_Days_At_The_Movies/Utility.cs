using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beautiful_Days_At_The_Movies_Messages;

namespace Beautiful_Days_At_The_Movies
{
    public class Utility
    {
        public int GetValidDay(string firstLast)
        {
            Message.InputDay(firstLast);
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.DayIsNotANumber(input, firstLast);
                }
                else
                {
                    if (!CheckIfPositive(input))
                    {
                        Message.DayMustBePositive(firstLast);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetDivisor()
        {
            Message.InputDivisor();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.DivisorIsNotANumber(input);
                }
                else
                {
                    if (!CheckIfGreaterThanOne(input))
                    {
                        Message.DivisorMustBeGreaterThanOne();
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

        public bool CheckIfLastIsGreaterThanFirst(int firstDay, int lastDay)
        {
            return lastDay > firstDay;
        }

        public bool CheckIfGreaterThanOne(string input)
        {
            return int.Parse(input) > 1;
        }

        public List<int> CalculateBeautifulDays(int firstDay, int lastDay, int divisor)
        {
            var beautifulDays = new List<int>();
            for (int i = firstDay; i <= lastDay; i++)
            {
                if (GetAbsoluteDifference(i) % divisor == 0)
                {
                    beautifulDays.Add(i);
                }
            }
            return beautifulDays;
        }

        public int GetAbsoluteDifference(int num)
        {
            var reverseOfNum = GetReverseOfNum(num);
            return Math.Abs(num - reverseOfNum);
        }

        public int GetReverseOfNum(int num)
        {
            var numReversedAsString = new string(num.ToString().ToCharArray().Reverse().ToArray());
            return int.Parse(numReversedAsString);
        }

        public void DisplayResults(int firstDay, int lastDay, List<int> beautifulDays)
        {
            if (beautifulDays.Count == 0)
            {
                Message.WereNoBeautifulDays(firstDay, lastDay);
            }
            else
            {
                Message.DisplayBeautifulDays(firstDay, lastDay, beautifulDays);
            }
        }
    }
}
