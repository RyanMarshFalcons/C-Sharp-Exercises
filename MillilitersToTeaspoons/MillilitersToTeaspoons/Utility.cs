using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MillilitersToTeaspoons_Messages;

namespace MillilitersToTeaspoons
{
    public class Utility
    {
        public const double TeaspoonsPerMilliliter = 0.202884;
        public double GetValidEntry()
        {
            Message.EnterVolume();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotAVolume(input);
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

        public double GetTeaspoons(double milliliters)
        {
            return Math.Round(milliliters * TeaspoonsPerMilliliter, 2);
        }
    }
}
