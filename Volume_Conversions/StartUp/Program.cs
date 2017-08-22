using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volume_Conversions;
using Volume_Conversions_Messages;

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
                    var numGallons = utility.GetValidNumber("Gallons");
                    var numLiters = utility.GetLiters(numGallons);
                    Message.DisplayResult(numGallons, numLiters, "Gallons", "Liters");
                    break;
                case "B":
                    var numLit = utility.GetValidNumber("Liters");
                    var numGal = utility.GetGallons(numLit);
                    Message.DisplayResult(numLit, numGal, "Liters", "Gallons");
                    break;
                case "C":
                    var numMilliliters = utility.GetValidNumber("Milliliters");
                    var numTeaspoons = utility.GetTeaspoons(numMilliliters);
                    Message.DisplayResult(numMilliliters, numTeaspoons, "Milliliters", "Teaspoons");
                    break;
                case "D":
                    var numTea = utility.GetValidNumber("Teaspoons");
                    var numMil = utility.GetMilliliters(numTea);
                    Message.DisplayResult(numTea, numMil, "Teaspoons", "Milliliters");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
