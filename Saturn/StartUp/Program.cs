using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saturn;
using Saturn_Messages;

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
            var SaturnAmount = 0.0;
            while (selection != "D")
            {
                selection = utility.GetValidSelection();
                switch (selection)
                {
                    case "A":
                        EarthAmount = utility.GetValidEntry("pounds", "you weigh", "weight");
                        SaturnAmount = utility.GetWeightOnSaturn(EarthAmount);
                        Message.DisplayResults("weight", "pounds", SaturnAmount);
                        break;
                    case "B":
                        EarthAmount = utility.GetValidEntry("inches", "your vertical leap is", "vertical leap");
                        SaturnAmount = utility.GetVerticalLeapOnSaturn(EarthAmount);
                        Message.DisplayResults("vertical leap", "inches", SaturnAmount);
                        break;
                    case "C":
                        EarthAmount = utility.GetValidEntry("years", "old you are", "age");
                        SaturnAmount = utility.GetAgeOnSaturn(EarthAmount);
                        Message.DisplayResults("age", "years", SaturnAmount);
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
