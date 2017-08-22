using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Length_Conversions;
using Length_Conversions_Messages;

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
                    var numFeet = utility.GetValidNumber("Feet");
                    var numMeters = utility.GetMeters(numFeet);
                    Message.DisplayResult(numFeet, numMeters, "Feet", "Meters");
                    break;
                case "B":
                    var numMet = utility.GetValidNumber("Meters");
                    var numFee = utility.GetFeet(numMet);
                    Message.DisplayResult(numMet, numFee, "Meters", "Feet");
                    break;
                case "C":
                    var numKilometers = utility.GetValidNumber("Kilometers");
                    var numMiles = utility.GetMiles(numKilometers);
                    Message.DisplayResult(numKilometers, numMiles, "Kilometers", "Miles");
                    break;
                case "D":
                    var numMil = utility.GetValidNumber("Miles");
                    var numKil = utility.GetKilometers(numMil);
                    Message.DisplayResult(numMil, numKil, "Miles", "Kilometers");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
