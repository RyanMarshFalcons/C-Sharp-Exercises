using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FahrenheitToCelsius_Messages;

namespace FahrenheitToCelsius
{
    public class Utility
    {
        public const double FtoCConversion1 = 32;
        public const double FtoCConversion2 = 0.55555555555556;
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

        public double GetCelsius(double fahrenheit)
        {
            return Math.Round((fahrenheit - FtoCConversion1) * FtoCConversion2, 2);
        }
    }
}
