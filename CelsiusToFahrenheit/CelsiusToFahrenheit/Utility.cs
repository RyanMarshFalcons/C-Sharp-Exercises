using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelsiusToFahrenheit_Messages;

namespace CelsiusToFahrenheit
{
    public class Utility
    {
        public const double CtoFconversionPart1 = 1.8;
        public const double CtoFconversionPart2 = 32;

        public double GetValidEntry()
        {
            Message.EnterTemperature();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotATemperature(input);
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

        public double GetFahrenheit(double celsius)
        {
            return Math.Round((celsius * CtoFconversionPart1) + CtoFconversionPart2, 2);
        }
    }
}
