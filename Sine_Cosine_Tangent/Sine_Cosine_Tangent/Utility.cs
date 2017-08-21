using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sine_Cosine_Tangent_Messages;

namespace Sine_Cosine_Tangent
{
    public class Utility
    {
        public double GetValidNumber()
        {
            Message.EnterNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return Double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public string GetTrigFunction()
        {
            Message.EnterTrigFunction();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfSinCosTan(input) == false)
                {
                    Message.NotATrigFunction(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfSinCosTan(string input)
        {
            return ((input == "A") || (input == "B") || (input == "C"));
        }

        public double GetSine(double num)
        {
            return Math.Round(Math.Sin(num), 2);
        }

        public double GetCosine(double num)
        {
            return Math.Round(Math.Cos(num), 2);
        }

        public double GetTangent(double num)
        {
            return Math.Round(Math.Tan(num), 2);
        }
    }
}
