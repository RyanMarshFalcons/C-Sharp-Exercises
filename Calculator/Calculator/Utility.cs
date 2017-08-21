using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Messages;

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
            return Double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public string GetValidOperator()
        {
            Message.EnterOperator();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfOperator(input) == false)
                {
                    Message.NotAnOperator(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfOperator(string input)
        {
            return ((input == "+") || (input == "-") || (input == "*") || (input == "/"));
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
    }
}
