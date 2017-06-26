using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Change
{
    public enum InputType { Empty, Zero, Negative, NotADecimal, NotAnInt, TooManyTrailingDigits, Valid };
    public class Evaluation
    {
        public decimal EvaluateDecimal(string userInput)
        {
            var typeOfInput = InputType.Valid;
            var verifier = new Verification();

            if (verifier.NotADecimal(userInput))
            {
                if (verifier.Empty(userInput))
                {
                    typeOfInput = InputType.Empty;
                }
                else
                {
                    typeOfInput = InputType.NotADecimal;
                }
            }
            else
            {
                decimal userInputAsDecimal = Decimal.Parse(userInput);
                if (verifier.Zero(userInputAsDecimal))
                {
                    typeOfInput = InputType.Zero;
                }
                if (verifier.Negative(userInputAsDecimal))
                {
                    typeOfInput = InputType.Negative;
                }
                if (verifier.TooManyTrailingDigits(userInputAsDecimal))
                {
                    typeOfInput = InputType.TooManyTrailingDigits;
                }
            }

            switch (typeOfInput)
            {
                case InputType.Empty:
                    Message.IsEmpty();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.Zero:
                    Message.IsZero();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.Negative:
                    Message.IsNegative();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.NotADecimal:
                    Message.IsNotADecimal(userInput);
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.TooManyTrailingDigits:
                    Message.HasTooManyTrailingDigits();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.Valid:
                    break;
                default:
                    throw new InvalidOperationException();
                    break;
            }
            return Decimal.Parse(userInput);
        }

        public int EvaluateInt(string userInput)
        {
            var typeOfInput = InputType.Valid;
            var verifier = new Verification();

            if (verifier.NotAnInt(userInput))
            {
                if (verifier.Empty(userInput))
                {
                    typeOfInput = InputType.Empty;
                }
                else
                {
                    typeOfInput = InputType.NotAnInt;
                }
            }
            else
            {
                var userInputAsInt = Int32.Parse(userInput);
                if (verifier.Negative(userInputAsInt))
                {
                    typeOfInput = InputType.Negative;
                }
            }

            switch (typeOfInput)
            {
                case InputType.Empty:
                    Message.IsEmpty();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.Negative:
                    Message.IsNegative();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.NotAnInt:
                    Message.IsNotAnInteger(userInput);
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case InputType.Valid:
                    break;
                default:
                    throw new InvalidOperationException();
                    break;
            }
            return Int32.Parse(userInput);
        }

        public Dictionary<string, decimal> LogOfDenominationsInDrawer()
        {
            var cashInDrawer = new Dictionary<string, Decimal>();                                                                    
            var denominationNames = new string[] { "ONE HUNDRED", "TWENTY", "TEN", "FIVE", "ONE", "QUARTER", "DIME", "NICKEL", "PENNY" };
            var denominationCount = new int[9];
            var denominationValue = new decimal[] { 100M, 20M, 10M, 5M, 1M, .25M, .1M, .05M, .01M };

            for (int i = 0; i < denominationNames.Length; i++)
            {
                Console.Write($"Please input how many {denominationNames[i]}s you have in your drawer: ");
                var userInput = Console.ReadLine();
                denominationCount[i] = EvaluateInt(userInput);
                cashInDrawer.Add  (denominationNames[i], denominationCount[i]*denominationValue[i]);
            }
            return cashInDrawer;
        } 
    }
}
