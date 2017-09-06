using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mean_Median_Mode_Messages;

namespace Mean_Median_Mode
{
    public class Utility
    {
        public double GetValidEntry()
        {
            Message.EnterNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return Double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherNum();
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }

        public double FindTheMean(List<double> numbers)
        {
            var sumOfNums = 0.0;
            foreach (var num in numbers)
            {
                sumOfNums += num;
            }
            return Math.Round((sumOfNums / numbers.Count), 2);
        }

        public bool CheckIfEven(int count)
        {
            return count % 2 == 0;
        }

        public double FindTheMedian(int counter, List<double> numbers)
        {
            numbers.Sort();
            if (CheckIfEven(counter) == true)
            {
                return ((numbers[(counter / 2) - 1]) + numbers[counter / 2]) / 2;
            }
            else
            {
                return numbers[((counter + 1) / 2) - 1];
            }
        }

        public int GetMaxCount(List<double> numList)
        {
            var counter = 0;
            var placeHolder = 0;
            numList.Sort();
            while (numList.Count > 0)
            {
                counter = 0;
                for (int i = 0; i < numList.Count; i++)
                {
                    if (numList[0] == numList[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > placeHolder)
                {
                    placeHolder = counter;
                }
                numList.RemoveRange(0, counter);
            }
            return placeHolder;
        }

        public List<double> FindTheMode(int maxCount, List<double> numList)
        {
            var modeList = new List<double>();
            var counter = 0;
            numList.Sort();
            while (numList.Count > 0)
            {
                counter = 0;
                for (int i = 0; i < numList.Count; i++)
                {
                    if (numList[0] == numList[i])
                    {
                        counter++;
                        if (counter == maxCount)
                        {
                            modeList.Add(numList[i]);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                numList.RemoveRange(0, counter);
            }
            return modeList;
        }
    }
}

