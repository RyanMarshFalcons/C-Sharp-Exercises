using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets;
using Planets_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var EarthAmount = 0.0;
            var PlanetAmount = 0.0;
            var planetSelection = utility.GetValidPlanetSelection();
            var planet = utility.ConvertLetterToPlanet(planetSelection);
            var measureSelection = utility.GetValidMeasureSelection(planet.ToString());
            switch (measureSelection)
            {
                case "A":
                    EarthAmount = utility.GetValidMeasurement("pounds", "you weigh", "weight");
                    PlanetAmount = utility.GetWeightOnPlanet(EarthAmount, planet);
                    Message.DisplayResults("weight", planet.ToString(), "pounds", PlanetAmount);
                    break;
                case "B":
                    EarthAmount = utility.GetValidMeasurement("inches", "your vertical leap is", "vertical leap");
                    PlanetAmount = utility.GetVerticalLeapOnPlanet(EarthAmount, planet);
                    Message.DisplayResults("vertical leap", planet.ToString(), "inches", PlanetAmount);
                    break;
                case "C":
                    EarthAmount = utility.GetValidMeasurement("years", "old you are", "age");
                    PlanetAmount = utility.GetAgeOnPlanet(EarthAmount, planet);
                    Message.DisplayResults("age", planet.ToString(), "years old", PlanetAmount);
                    break;
            }
            Console.ReadLine();
        }
    }
}
