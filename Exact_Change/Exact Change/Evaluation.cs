using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Change
{
    public enum InputType { Empty, Zero, Negative, NotADecimal, NotAnInt, TooManyTrailingDigits, Valid };
    public class Evaluation
    {
        public bool IsAValidDecimal(string userInput)
        {
            return (GetInputTypeForDecimal(userInput) == InputType.Valid);
        }

        public decimal ConvertToADecimal(string userInput)
        {
            return decimal.Parse(userInput);
        }

        public void InvalidDecimal(string userInput)
        {
            var typeOfInput = GetInputTypeForDecimal(userInput);
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
            }
        }

        public InputType GetInputTypeForDecimal(string userInput)
        {
            var typeOfInput = InputType.Valid;
            if (NotADecimal(userInput))
            {
                if (Empty(userInput))
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
                return HaveValidDecimal(userInput);
            }
            return typeOfInput;
        }

        public InputType HaveValidDecimal(string userInput)
        {
            var typeOfInput = InputType.Valid;
            var userInputAsDecimal = decimal.Parse(userInput);
            if (Zero(userInputAsDecimal))
            {
                typeOfInput = InputType.Zero;
            }
            if (Negative(userInputAsDecimal))
            {
                typeOfInput = InputType.Negative;
            }
            if (TooManyTrailingDigits(userInputAsDecimal))
            {
                typeOfInput = InputType.TooManyTrailingDigits;
            }
            return typeOfInput;
        }

        public bool IsAValidInt(string userInput)
        {
            return (GetInputTypeForInt(userInput) == InputType.Valid);
        }

        public int ConvertToInt(string userInput)
        {
            return int.Parse(userInput);
        }

        public void InvalidInt(string userInput)
        {
            var typeOfInput = GetInputTypeForInt(userInput);

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
            }
        }

        public InputType GetInputTypeForInt(string userInput)
        {
            var typeOfInput = InputType.Valid;
            if (NotAnInt(userInput))
            {
                if (Empty(userInput))
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
                return HaveValidDecimal(userInput);
            }
            return typeOfInput;
        } 

        public InputType HaveValidInt(string userInput)
        {
            var typeOfInput = InputType.Valid;
            var userInputAsInt = Int32.Parse(userInput);
            if (userInputAsInt < 0)
            {
                return InputType.Negative;
            }
            return typeOfInput;
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
                if (GetInputTypeForInt(userInput) == InputType.Valid)
                {
                    denominationCount[i] = ConvertToInt(userInput);
                    cashInDrawer.Add(denominationNames[i], denominationCount[i] * denominationValue[i]);
                }
                else
                {
                    InvalidInt(userInput);
                }
            }
            return cashInDrawer;
        }

        public bool Empty(string userEntry)
        {
            return userEntry == "";
        }

        public bool NotADecimal(string userEntry)
        {
            var result = 0M;
            return !decimal.TryParse(userEntry, out result);
        }
        public bool NotAnInt(string userEntry)
        {
            var result = 0;
            return !int.TryParse(userEntry, out result);
        }

        public bool Zero(decimal userEntryAsDecimal)
        {
            return userEntryAsDecimal == 0;
        }

        public bool Negative(decimal userEntryAsDecimal)
        {
            return userEntryAsDecimal < 0;
        }

        public bool TooManyTrailingDigits(decimal inputAsDecimal)
        {
            return ((SqlDecimal)(decimal)inputAsDecimal).Scale > 2;
        }
    }
}
