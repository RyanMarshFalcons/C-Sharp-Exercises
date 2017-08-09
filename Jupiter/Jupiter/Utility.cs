using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jupiter_Messages;

namespace Jupiter
{
    public class Utility
    {
        public const double EarthToJupiterGravity = 2.36;
        public const double EarthToJupiterRotations = 0.0843;

        public string GetValidSelection()
        {
            Message.Selections();
            var isValidSelection = false;
            var input = "";
            while (isValidSelection == false)
            {
                input = Console.ReadLine();
                if (IsABCD(input) == false)
                {
                    Message.InvalidSelection(input);
                    Message.Selections();
                }
                else
                {
                    isValidSelection = true;
                }
            }
            return input;
        }

        public bool IsABCD(string input)
        {
            if ((input == "A") || (input == "B") || (input == "C") || (input == "D"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetValidEntry(string unitOfMeasurement, string action, string typeOfMeasurement)
        {
            Message.EnterNumber(unitOfMeasurement, action);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotAValidEntry(input, typeOfMeasurement, unitOfMeasurement);
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
            return Double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return Double.Parse(input) > 0;
        }

        public double GetWeightOnJupiter(double EarthWeight)
        {
            return Math.Round(EarthWeight * EarthToJupiterGravity, 2);
        }

        public double GetVerticalLeapOnJupiter(double EarthHeight)
        {
            return Math.Round(EarthHeight / EarthToJupiterGravity, 2);
        }

        public double GetAgeOnJupiter(double EarthAge)
        {
            return Math.Round(EarthAge * EarthToJupiterRotations, 2);
        }
    }
}
