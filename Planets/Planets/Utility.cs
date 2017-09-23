using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets_Messages;
using System.Text.RegularExpressions;

namespace Planets
{
    public enum Planet { Mercury, Venus, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto};
    public class Utility
    {
        public const double EarthToJupiterGravity = 2.36;
        public const double EarthToJupiterRotations = 0.0843;
        public const double EarthToMarsGravity = 0.377;
        public const double EarthToMarsRotations = 0.531;
        public const double EarthToMercuryGravity = 0.378;
        public const double EarthToMercuryRotations = 4.152;
        public const double EarthToNeptuneGravity = 1.12;
        public const double EarthToNeptuneRotations = 0.006;
        public const double EarthToPlutoGravity = 0.071;
        public const double EarthToPlutoRotations = 0.00402;
        public const double EarthToSaturnGravity = 0.916;
        public const double EarthToSaturnRotations = 0.0339;
        public const double EarthToUranusGravity = 0.889;
        public const double EarthToUranusRotations = 0.0119;
        public const double EarthToVenusGravity = 0.907;
        public const double EarthToVenusRotations = 1.625;

        public string GetValidPlanetSelection()
        {
            Message.SelectPlanet();
            var isValidSelection = false;
            var input = "";
            while (isValidSelection == false)
            {
                input = Console.ReadLine();
                if (IsABCDEFGH(input) == false)
                {
                    Message.InvalidPlanetSelection(input);
                }
                else
                {
                    isValidSelection = true;
                }
            }
            return input;
        }

        public bool IsABCDEFGH(string input)
        {
            return Regex.IsMatch(input, "[A-H]") && input.Length == 1;
        }

        public string GetValidMeasureSelection(string planet)
        {
            Message.MeasureSelections(planet);
            var isValidSelection = false;
            var input = "";
            while (isValidSelection == false)
            {
                input = Console.ReadLine();
                if (IsABC(input) == false)
                {
                    Message.InvalidMeasureSelection(input, planet);
                }
                else
                {
                    isValidSelection = true;
                }
            }
            return input;
        }

        public bool IsABC(string input)
        {
            return Regex.IsMatch(input, "[A-C]") && input.Length == 1;
        }

        public double GetValidMeasurement(string unitOfMeasurement, string action, string typeOfMeasurement)
        {
            Message.EnterNumber(unitOfMeasurement, action);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotAValidMeasurement(input, typeOfMeasurement, unitOfMeasurement);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive(typeOfMeasurement, unitOfMeasurement);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return double.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return double.Parse(input) > 0;
        }

        public Planet ConvertLetterToPlanet(string planetSelection)
        {
            switch (planetSelection)
            {
                case "A":
                    return Planet.Mercury;
                    break;
                case "B":
                    return Planet.Venus;
                    break;
                case "C":
                    return Planet.Mars;
                    break;
                case "D":
                    return Planet.Jupiter;
                    break;
                case "E":
                    return Planet.Saturn;
                    break;
                case "F":
                    return Planet.Uranus;
                    break;
                case "G":
                    return Planet.Neptune;
                    break;
                case "H":
                default:
                    return Planet.Pluto;
                    break;
            }
        }

        public double GetWeightOnPlanet(double EarthWeight, Planet planet)
        {
            switch (planet)
            {
                case Planet.Mercury:
                    return Math.Round(EarthWeight * EarthToMercuryGravity, 2);
                    break;
                case Planet.Venus:
                    return Math.Round(EarthWeight * EarthToVenusGravity, 2);
                    break;
                case Planet.Mars:
                    return Math.Round(EarthWeight * EarthToMarsGravity, 2);
                    break;
                case Planet.Jupiter:
                    return Math.Round(EarthWeight * EarthToJupiterGravity, 2);
                    break;
                case Planet.Saturn:
                    return Math.Round(EarthWeight * EarthToSaturnGravity, 2);
                    break;
                case Planet.Uranus:
                    return Math.Round(EarthWeight * EarthToUranusGravity, 2);
                    break;
                case Planet.Neptune:
                    return Math.Round(EarthWeight * EarthToNeptuneGravity, 2);
                    break;
                case Planet.Pluto:
                default:
                    return Math.Round(EarthWeight * EarthToPlutoGravity, 2);
                    break;
            }
        }

        public double GetVerticalLeapOnPlanet(double EarthHeight, Planet planet)
        {
            switch (planet)
            {
                case Planet.Mercury:
                    return Math.Round(EarthHeight / EarthToMercuryGravity, 2);
                    break;
                case Planet.Venus:
                    return Math.Round(EarthHeight / EarthToVenusGravity, 2);
                    break;
                case Planet.Mars:
                    return Math.Round(EarthHeight / EarthToMarsGravity, 2);
                    break;
                case Planet.Jupiter:
                    return Math.Round(EarthHeight / EarthToJupiterGravity, 2);
                    break;
                case Planet.Saturn:
                    return Math.Round(EarthHeight / EarthToSaturnGravity, 2);
                    break;
                case Planet.Uranus:
                    return Math.Round(EarthHeight / EarthToUranusGravity, 2);
                    break;
                case Planet.Neptune:
                    return Math.Round(EarthHeight / EarthToNeptuneGravity, 2);
                    break;
                case Planet.Pluto:
                default:
                    return Math.Round(EarthHeight / EarthToPlutoGravity, 2);
                    break;
            }
        }

        public double GetAgeOnPlanet(double EarthAge, Planet planet)
        {
            switch (planet)
            {
                case Planet.Mercury:
                    return Math.Round(EarthAge * EarthToMercuryRotations, 2);
                    break;
                case Planet.Venus:
                    return Math.Round(EarthAge * EarthToVenusRotations, 2);
                    break;
                case Planet.Mars:
                    return Math.Round(EarthAge * EarthToMarsRotations, 2);
                    break;
                case Planet.Jupiter:
                    return Math.Round(EarthAge * EarthToJupiterRotations, 2);
                    break;
                case Planet.Saturn:
                    return Math.Round(EarthAge * EarthToSaturnRotations, 2);
                    break;
                case Planet.Uranus:
                    return Math.Round(EarthAge * EarthToUranusRotations, 2);
                    break;
                case Planet.Neptune:
                    return Math.Round(EarthAge * EarthToNeptuneRotations, 2);
                    break;
                case Planet.Pluto:
                default:
                    return Math.Round(EarthAge * EarthToPlutoRotations, 2);
                    break;
            }
        }
    }
}
