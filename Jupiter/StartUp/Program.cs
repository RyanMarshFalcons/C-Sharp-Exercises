using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jupiter;
using Jupiter_Messages;

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
            var JupiterAmount = 0.0;
            while (selection != "D")
            {
                selection = utility.GetValidSelection();
                switch (selection)
                {
                    case "A":
                        EarthAmount = utility.GetValidEntry("pounds", "you weigh", "weight");
                        JupiterAmount = utility.GetWeightOnJupiter(EarthAmount);
                        Message.DisplayResults("weight", "pounds", JupiterAmount);
                        break;
                    case "B":
                        EarthAmount = utility.GetValidEntry("inches", "your vertical leap is", "vertical leap");
                        JupiterAmount = utility.GetVerticalLeapOnJupiter(EarthAmount);
                        Message.DisplayResults("vertical leap", "inches", JupiterAmount);
                        break;
                    case "C":
                        EarthAmount = utility.GetValidEntry("years", "old you are", "age");
                        JupiterAmount = utility.GetAgeOnJupiter(EarthAmount);
                        Message.DisplayResults("age", "years", JupiterAmount);
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
