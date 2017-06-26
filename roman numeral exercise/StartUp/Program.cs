using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roman_Numerals;

namespace StartUp
{
    public class Program
    {
        public enum InputType { Empty, Zero, Negative, TooHigh, NotANumber, Valid};
        public static void Main(string[] args)
        {
            Message.Welcome();
            string userInput = Console.ReadLine();
            var typeOfInput = InputType.Valid;
            var verifier = new Verification();
            
            if (verifier.NotANumber(userInput))
            {
                if (verifier.Empty(userInput))
                {
                    typeOfInput = InputType.Empty;
                }
                else
                {
                    typeOfInput = InputType.NotANumber;
                }
            }
            else
            {
                int userInputAsInt = Int32.Parse(userInput);
                if (verifier.Zero(userInputAsInt))
                {
                    typeOfInput = InputType.Zero;
                }
                if(verifier.Negative(userInputAsInt))
                {
                    typeOfInput = InputType.Negative;
                }
                if(verifier.TooHigh(userInputAsInt))
                {
                    typeOfInput = InputType.TooHigh;
                }
            }

            switch (typeOfInput)
            {
                case InputType.Empty:
                    Message.IsEmpty();
                    break;
                case InputType.Zero:
                    Message.IsZero();
                    break;
                case InputType.Negative:
                    Message.IsNegative();
                    break;
                case InputType.TooHigh:
                    Message.IsTooHigh();
                    break;
                case InputType.NotANumber:
                    Message.IsNotAnInteger(userInput);
                    break;
                case InputType.Valid:
                    var RomanNumeralBuilder = new Builder(Int32.Parse(userInput));
                    Message.RomanNumeral(RomanNumeralBuilder.BuildRomanNumeral());                 
                    break;
                default:
                    throw new InvalidOperationException();
                    break;
            }

            Console.ReadLine();
        }
    }
}
