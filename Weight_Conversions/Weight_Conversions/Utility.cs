using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Weight_Conversions_Messages;

namespace Weight_Conversions
{
    public class Utility
    {
        public const double OuncesPerGram = 0.035274;
        public const double GramsPerOunce = 28.3495;
        public const double PoundsPerKilogram = 2.20462;
        public const double KilogramsPerPound = 0.453592;

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

        public double GetValidNumber(string weightType)
        {
            Message.EnterWeight(weightType);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotAWeight(input, weightType);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative(weightType);
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

        public double GetOunces(double grams)
        {
            return Math.Round(grams * OuncesPerGram, 2);
        }

        public double GetGrams(double ounces)
        {
            return Math.Round(ounces * GramsPerOunce, 2);
        }

        public double GetPounds(double kilograms)
        {
            return Math.Round(kilograms * PoundsPerKilogram, 2);
        }

        public double GetKilograms(double pounds)
        {
            return Math.Round(pounds * KilogramsPerPound, 2);
        }
    }
}
