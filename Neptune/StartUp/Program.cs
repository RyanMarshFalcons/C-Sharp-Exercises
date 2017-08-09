using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neptune;
using Neptune_Messages;

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
            var NeptuneAmount = 0.0;
            while (selection != "D")
            {
                selection = utility.GetValidSelection();
                switch (selection)
                {
                    case "A":
                        EarthAmount = utility.GetValidEntry("pounds", "you weigh", "weight");
                        NeptuneAmount = utility.GetWeightOnNeptune(EarthAmount);
                        Message.DisplayResults("weight", "pounds", NeptuneAmount);
                        break;
                    case "B":
                        EarthAmount = utility.GetValidEntry("inches", "your vertical leap is", "vertical leap");
                        NeptuneAmount = utility.GetVerticalLeapOnNeptune(EarthAmount);
                        Message.DisplayResults("vertical leap", "inches", NeptuneAmount);
                        break;
                    case "C":
                        EarthAmount = utility.GetValidEntry("years", "old you are", "age");
                        NeptuneAmount = utility.GetAgeOnNeptune(EarthAmount);
                        Message.DisplayResults("age", "years", NeptuneAmount);
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
