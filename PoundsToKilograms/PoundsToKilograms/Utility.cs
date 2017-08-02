using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoundsToKilograms_Messages;

namespace PoundsToKilograms
{
    public class Utility
    {
        public const double KilogramsPerPound = 0.453592;
        public double GetValidEntry()
        {
            Message.EnterWeight();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotAWeight(input);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return Double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public bool CheckIfNegative(string input)
        {
            return Double.Parse(input) < 0;
        }

        public double GetKilograms(double pounds)
        {
            return Math.Round(pounds * KilogramsPerPound, 2);
        }
    }
}
