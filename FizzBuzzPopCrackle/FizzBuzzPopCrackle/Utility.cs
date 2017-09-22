using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPopCrackle_Messages;
using System.Text.RegularExpressions;

namespace FizzBuzzPopCrackle
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
            return Regex.IsMatch(input, "^[A-O() ]+$") && input.Length == 1;
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
                    return "Crackle";
                    break;
                case "F":
                    return "FizzBuzz";
                    break;
                case "G":
                    return "FizzPop";
                    break;
                case "H":
                    return "FizzCrackle";
                    break;
                case "I":
                    return "BuzzPop";
                    break;
                case "J":
                    return "BuzzCrackle";
                    break;
                case "K":
                    return "PopCrackle";
                    break;
                case "L":
                    return "FizzBuzzPop";
                    break;
                case "M":
                    return "FizzBuzzCrackle";
                    break;
                case "N":
                    return "BuzzPopCrackle";
                    break;
                case "O":
                default:
                    return "FizzBuzzPopCrackle";
                    break;
            }
        }

        public string CalculateCorrectAnswer(int num)
        {
            if (IsFizz(num) && IsBuzz(num) && IsPop(num) && IsCrackle(num))
            {
                return "FizzBuzzPopCrackle";
            }
            else if (IsBuzz(num) && IsPop(num) && IsCrackle(num))
            {
                return "BuzzPopCrackle";
            }
            else if (IsFizz(num) && IsBuzz(num) && IsCrackle(num))
            {
                return "FizzBuzzCrackle";
            }
            else if (IsFizz(num) && IsBuzz(num) && IsPop(num))
            {
                return "FizzBuzzPop";
            }
            else if (IsPop(num) && IsCrackle(num))
            {
                return "PopCrackle";
            }
            else if (IsBuzz(num) && IsCrackle(num))
            {
                return "BuzzCrackle";
            }
            else if (IsBuzz(num) && IsPop(num))
            {
                return "BuzzPop";
            }
            else if (IsFizz(num) && IsCrackle(num))
            {
                return "FizzCrackle";
            }
            else if (IsFizz(num) && IsPop(num))
            {
                return "FizzPop";
            }
            else if (IsFizz(num) && IsBuzz(num))
            {
                return "FizzBuzz";
            }
            else if (IsCrackle(num))
            {
                return "Crackle";
            }
            else if (IsPop(num))
            {
                return "Pop";
            }
            else if (IsBuzz(num))
            {
                return "Buzz";
            }
            else if (IsFizz(num))
            {
                return "Fizz";
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

        public bool IsCrackle(int num)
        {
            return num % 11 == 0;
        }
    }
}
