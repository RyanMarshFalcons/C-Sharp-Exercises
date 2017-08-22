using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperature_Conversions;
using Temperature_Conversions_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var conversionType = utility.GetConversionType();
            switch (conversionType)
            {
                case "A":
                    var numCelsius = utility.GetValidNumber("Celsius");
                    var numFahrenheit = utility.GetFahrenheit(numCelsius);
                    Message.DisplayResult(numCelsius, numFahrenheit, "Celsius", "Fahrenheit");
                    break;
                case "B":
                    var numFahr = utility.GetValidNumber("Fahrenheit");
                    var numCel = utility.GetCelsius(numFahr);
                    Message.DisplayResult(numFahr, numCel, "Fahrenheit", "Celsius");
                    break;
                case "C":
                    var numKelvin = utility.GetValidNumber("Kelvin");
                    var numRankine = utility.GetRankine(numKelvin);
                    Message.DisplayResult(numKelvin, numRankine, "Kelvin", "Rankine");
                    break;
                case "D":
                    var numRank = utility.GetValidNumber("Rankine");
                    var numKel = utility.GetKelvin(numRank);
                    Message.DisplayResult(numRank, numKel, "Rankine", "Kelvin");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
