using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Median_Messages;

namespace Median
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

        public bool CheckIfEven(int count)
        {
            return count % 2 == 0;
        }

        public double FindTheMedian(int counter, List<double> numbers)
        {
            numbers.Sort();
            if (CheckIfEven(counter) == true)
            {
                return ((numbers[(counter/2) - 1]) + numbers[counter/2]) / 2;
            }
            else
            {
                return numbers[((counter + 1) / 2) - 1];
            }
        }
    }
}
