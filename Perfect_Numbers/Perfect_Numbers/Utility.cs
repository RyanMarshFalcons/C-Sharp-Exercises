using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perfect_Numbers_Messages;

namespace Perfect_Numbers
{
    public enum Classification { Perfect, Abundant, Deficient};
    public class Utility
    {
        public int GetUserNumber()
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

        public List<int> CalculateFactors(int userNum)
        {
            var factors = new List<int>();
            for (int i = 1; i < userNum; i++)
            {
                if (userNum % i == 0)
                {
                    factors.Add(i);
                }
            }
            return factors;
        }

        public int CalculateSumOfFactors(List<int> factors)
        {
            return factors.Sum();
        }

        public Classification DetermineClassifiation(int userNum, int sum)
        {
            if (sum == userNum)
            {
                return Classification.Perfect;
            }
            else if (sum > userNum)
            {
                return Classification.Abundant;
            }
            else
            {
                return Classification.Deficient;
            }
        } 

        public void DisplayResults(int userNum, int sum, Classification classification)
        {
            var classificationDefinitions = new Dictionary<Classification, string>()
            {
                {Classification.Abundant, "greater than" },
                {Classification.Deficient, "less than" },
                {Classification.Perfect, "equal to" }
            };
            Message.DisplayResults(userNum, classification.ToString(), sum, classificationDefinitions[classification]);

        }
    }
}
