using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPop_Messages;

namespace FizzBuzzPop
{
    public class Utility
    {
        public string GetValidGuess(int num)
        {
            var input = "";
            Message.EnterGuess(num);
            var validInput = false;
            while (validInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidGuess(input) == false)
                {
                    Message.InvalidGuess(input, num);
                }
                else
                {
                    validInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidGuess(string input)
        {
            return input == "A" || input == "B" || input == "C" || input == "D" || input == "E" || input == "F" || input == "G" || input == "H";
        }

        public string ConvertLetterToGuess(string guessLetter, int num)
        {
            switch (guessLetter)
            {
                case "A":
                    return num.ToString();
                    break;
                case "B":
                    return "Fizz";
                    break;
                case "C":
                    return "Buzz";
                    break;
                case "D":
                    return "Pop";
                    break;
                case "E":
                    return "FizzBuzz";
                    break;
                case "F":
                    return "FizzPop";
                    break;
                case "G":
                    return "BuzzPop";
                    break;
                case "H":
                default:
                    return "FizzBuzzPop";
                    break;
            }
        }

        public string CalculateCorrectAnswer(int num)
        {
            if ((IsFizz(num)) && (IsBuzz(num)) && (IsPop(num)))
            {
                return "FizzBuzzPop";
            }
            else if ((IsFizz(num)) && (IsBuzz(num)))
            {
                return "FizzBuzz";
            }
            else if ((IsFizz(num)) && (IsPop(num)))
            {
                return "FizzPop";
            }
            else if ((IsBuzz(num)) && (IsPop(num)))
            {
                return "BuzzPop";
            }
            else if (IsFizz(num))
            {
                return "Fizz";
            }
            else if (IsBuzz(num))
            {
                return "Buzz";
            }
            else if (IsPop(num))
            {
                return "Pop";
            }
            else
            {
                return num.ToString();
            }
        }

        public bool IsFizz(int num)
        {
            return num % 3 == 0;
        }

        public bool IsBuzz(int num)
        {
            return num % 5 == 0;
        }

        public bool IsPop(int num)
        {
            return num % 7 == 0;
        }
    }
}
