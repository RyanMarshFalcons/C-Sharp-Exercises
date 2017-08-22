using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weight_Conversions;
using Weight_Conversions_Messages;

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
                    var numGrams = utility.GetValidNumber("Grams");
                    var numOunces = utility.GetOunces(numGrams);
                    Message.DisplayResult(numGrams, numOunces, "Grams", "Ounces");
                    break;
                case "B":
                    var numOun = utility.GetValidNumber("Ounces");
                    var numGra = utility.GetGrams(numOun);
                    Message.DisplayResult(numOun, numGra, "Ounces", "Grams");
                    break;
                case "C":
                    var numKilograms = utility.GetValidNumber("Kilograms");
                    var numPounds = utility.GetPounds(numKilograms);
                    Message.DisplayResult(numKilograms, numPounds, "Kilograms", "Pounds");
                    break;
                case "D":
                    var numPou = utility.GetValidNumber("Pounds");
                    var numKil = utility.GetKilograms(numPou);
                    Message.DisplayResult(numPou, numKil, "Pounds", "Kilograms");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
