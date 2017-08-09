using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venus;
using Venus_Messages;

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
            var VenusAmount = 0.0;
            while (selection != "D")
            {
                selection = utility.GetValidSelection();
                switch (selection)
                {
                    case "A":
                        EarthAmount = utility.GetValidEntry("pounds", "you weigh", "weight");
                        VenusAmount = utility.GetWeightOnVenus(EarthAmount);
                        Message.DisplayResults("weight", "pounds", VenusAmount);
                        break;
                    case "B":
                        EarthAmount = utility.GetValidEntry("inches", "your vertical leap is", "vertical leap");
                        VenusAmount = utility.GetVerticalLeapOnVenus(EarthAmount);
                        Message.DisplayResults("vertical leap", "inches", VenusAmount);
                        break;
                    case "C":
                        EarthAmount = utility.GetValidEntry("years", "old you are", "age");
                        VenusAmount = utility.GetAgeOnVenus(EarthAmount);
                        Message.DisplayResults("age", "years", VenusAmount);
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
