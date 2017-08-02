using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GramsToOunces_Messages;

namespace GramsToOunces
{
    public class Utility
    {
        public const double OuncesPerGram = 0.035274;
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

        public double GetOunces(double grams)
        {
            return Math.Round(grams * OuncesPerGram, 2);
        }
    }
}
