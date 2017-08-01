using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentimetersToInches_Messages;

namespace CentimetersToInches
{
    public class Utility
    {
        public const double InchesPerCentimeter = 0.393701;
        public double GetValidEntry()
        {
            Message.EnterDistance();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotADistance(input);
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

        public double GetInches(double centimeters)
        {
            return Math.Round(centimeters * InchesPerCentimeter, 2);
        }
    }
}
