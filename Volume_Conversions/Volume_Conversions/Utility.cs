using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Volume_Conversions_Messages;

namespace Volume_Conversions
{
    public class Utility
    {
        public const double LitersPerGallon = 3.78541;
        public const double GallonsPerLiter = 0.264172;
        public const double TeaspoonsPerMilliliter = 0.202884;
        public const double MillilitersPerTeaspoon = 4.92892;

        public string GetConversionType()
        {
            Message.SelectConversion();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfABCD(input) == false)
                {
                    Message.NotAValidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfABCD(string input)
        {
            return Regex.IsMatch(input, "[A-D]") && input.Length == 1;
        }

        public double GetValidNumber(string volumeType)
        {
            Message.EnterVolume(volumeType);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotAVolume(input, volumeType);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative(volumeType);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return double.TryParse(input, out num);
        }

        public bool CheckIfNegative(string input)
        {
            return double.Parse(input) < 0;
        }

        public double GetLiters(double gallons)
        {
            return Math.Round(gallons * LitersPerGallon, 2);
        }

        public double GetGallons(double liters)
        {
            return Math.Round(liters * GallonsPerLiter, 2);
        }

        public double GetTeaspoons(double milliliters)
        {
            return Math.Round(milliliters * TeaspoonsPerMilliliter, 2);
        }

        public double GetMilliliters(double teaspoons)
        {
            return Math.Round(teaspoons * MillilitersPerTeaspoon, 2);
        }
    }
}
