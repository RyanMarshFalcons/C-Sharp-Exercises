using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pluto;
using Pluto_Messages;


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
            var PlutoAmount = 0.0;
            while (selection != "D")
            {
                selection = utility.GetValidSelection();
                switch (selection)
                {
                    case "A":
                        EarthAmount = utility.GetValidEntry("pounds", "you weigh", "weight");
                        PlutoAmount = utility.GetWeightOnPluto(EarthAmount);
                        Message.DisplayResults("weight", "pounds", PlutoAmount);
                        break;
                    case "B":
                        EarthAmount = utility.GetValidEntry("inches", "your vertical leap is", "vertical leap");
                        PlutoAmount = utility.GetVerticalLeapOnPluto(EarthAmount);
                        Message.DisplayResults("vertical leap", "inches", PlutoAmount);
                        break;
                    case "C":
                        EarthAmount = utility.GetValidEntry("years", "old you are", "age");
                        PlutoAmount = utility.GetAgeOnPluto(EarthAmount);
                        Message.DisplayResults("age", "years", PlutoAmount);
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
