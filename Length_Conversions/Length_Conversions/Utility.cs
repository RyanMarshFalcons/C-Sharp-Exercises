using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Length_Conversions_Messages;
using System.Text.RegularExpressions;

namespace Length_Conversions
{
    public class Utility
    {
        public const double MetersPerFoot = 0.3048;
        public const double FeetPerMeter = 3.28084;
        public const double MilesPerKilometer = 0.621371;
        public const double KilometersPerMile = 1.60934;

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

        public double GetValidNumber(string lengthType)
        {
            Message.EnterLength(lengthType);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotALength(input, lengthType);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative(lengthType);
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
            return Double.TryParse(input, out num);
        }

        public bool CheckIfNegative(string input)
        {
            return Double.Parse(input) < 0;
        }

        public double GetMeters(double feet)
        {
            return Math.Round(feet * MetersPerFoot, 2);
        }

        public double GetFeet(double meters)
        {
            return Math.Round(meters * FeetPerMeter, 2);
        }

        public double GetMiles(double kilometers)
        {
            return Math.Round(kilometers * MilesPerKilometer, 2);
        }

        public double GetKilometers(double miles)
        {
            return Math.Round(miles * KilometersPerMile, 2);
        }
    }
}
