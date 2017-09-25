using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Temperature_Conversions_Messages;

namespace Temperature_Conversions
{
    public class Utility
    {
        public const double CtoFconversionPart1 = 1.8;
        public const double CtoFconversionPart2 = 32;
        public const double FtoCConversion1 = 32;
        public const double FtoCConversion2 = 0.55555556;
        public const double KtoRconversion = 1.8;
        public const double RtoKconversion = 0.55555556;

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

        public double GetValidNumber(string temperatureType)
        {
            Message.EnterTemperature(temperatureType);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotATemperature(input, temperatureType);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return double.TryParse(input, out num);
        }

        public double GetFahrenheit(double celsius)
        {
            return Math.Round((celsius * CtoFconversionPart1) + CtoFconversionPart2, 2);
        }

        public double GetCelsius(double fahrenheit)
        {
            return Math.Round((fahrenheit - FtoCConversion1) * FtoCConversion2, 2);
        }

        public double GetRankine(double kelvin)
        {
            return Math.Round(kelvin * KtoRconversion, 2);
        }

        public double GetKelvin(double rankine)
        {
            return Math.Round(rankine * RtoKconversion, 2);
        }
    }
}
