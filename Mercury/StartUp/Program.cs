using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercury;
using Mercury_Messsages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var selection = "";
            var EarthAmount = 0.0;
            var MercuryAmount = 0.0;
            while (selection != "D")
            {
                selection = utility.GetValidSelection();
                switch (selection)
                {
                    case "A":
                        EarthAmount = utility.GetValidEntry("pounds", "you weigh", "weight");
                        MercuryAmount = utility.GetWeightOnMercury(EarthAmount);
                        Message.DisplayResults("weight", "pounds", MercuryAmount);
                        break;
                    case "B":
                        EarthAmount = utility.GetValidEntry("inches", "your vertical leap is", "vertical leap");
                        MercuryAmount = utility.GetVerticalLeapOnMercury(EarthAmount);
                        Message.DisplayResults("vertical leap", "inches", MercuryAmount);
                        break;
                    case "C":
                        EarthAmount = utility.GetValidEntry("years", "old you are", "age");
                        MercuryAmount = utility.GetAgeOnMercury(EarthAmount);
                        Message.DisplayResults("age", "years", MercuryAmount);
                        break;
                    case "D":
                    default:
                        break;
                }
            }
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
