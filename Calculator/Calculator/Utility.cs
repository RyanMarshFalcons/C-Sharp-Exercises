using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Messages;
using System.Text.RegularExpressions;

namespace Calculator
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
            return double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return double.TryParse(input, out num);
        }

        public string GetValidOperatorSelection()
        {
            Message.SelectOperator();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.NotAValidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return (Regex.IsMatch(input, "^[A-K() ]+$") && input.Length == 1);
        }

        public double GetSum(double num1, double num2)
        {
            return Math.Round(num1 + num2, 2);
        }

        public double GetDifference(double num1, double num2)
        {
            return Math.Round(num1 - num2, 2);
        }

        public double GetProduct(double num1, double num2)
        {
            return Math.Round(num1 * num2, 2);
        }

        public double GetQuotient(double num1, double num2)
        {
            return Math.Round(num1 / num2, 2);
        }

        public double GetNumberSquared(double num)
        {
            return Math.Round(num * num, 2);
        }

        public double GetNumberCubed(double num)
        {
            return Math.Round(num * num * num, 2);
        }

        public double GetNumberTesseracted(double num)
        {
            return Math.Round(num * num * num * num, 2);
        }

        public double GetSquareRoot(double num)
        {
            return Math.Round(Math.Sqrt(num), 2);
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
