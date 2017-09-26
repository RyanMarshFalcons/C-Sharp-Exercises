using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrabble_Score_Messages;
using System.Text.RegularExpressions;

namespace Scrabble_Score
{
    public enum SquareType { Regular, DoubleLetter, TripleLetter, DoubleWord, TripleWord};
    public class Utility
    {
        public string GetValidWord()
        {
            var userInput = "";
            var validInput = false;
            Message.RequestUserInput();
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.TooShort();
                }
                else if (CheckIfTooLong(userInput))
                {
                    Message.TooLong();
                }
                else if (ContainsOnlyLetters(userInput) == false)
                {
                    Message.ContainsNonLetters();
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string userInput)
        {
            return userInput.Length < 1;
        }

        public bool CheckIfTooLong(string userInput)
        {
            return userInput.Length > 15;
        }

        public bool ContainsOnlyLetters(string userInput)
        {
            return Regex.IsMatch(userInput, "^[a-zA-Z]+$");
        }

        public int[] CalculateBaseValues(string userWord)
        {
            userWord = userWord.ToUpper();
            var LetterValue = new Dictionary<char, int>()
            {
                {'A',  1},
                {'B',  3},
                {'C',  3},
                {'D',  2},
                {'E',  1},
                {'F',  4},
                {'G',  2},
                {'H',  4},
                {'I',  1},
                {'J',  8},
                {'K',  5},
                {'L',  1},
                {'M',  3},
                {'N',  1},
                {'O',  1},
                {'P',  3},
                {'Q',  10},
                {'R',  1},
                {'S',  1},
                {'T',  1},
                {'U',  1},
                {'V',  4},
                {'W',  4},
                {'X',  8},
                {'Y',  4},
                {'Z',  10},
            };
            var baseValues = new int[userWord.Length];
            for (int i = 0; i < userWord.Length; i++)
            {
                baseValues[i] = LetterValue[userWord[i]];
            }
            return baseValues;
        }

        public SquareType[] GetSquareTypes(string userWord)
        {
            var squareTypes = new SquareType[userWord.Length];
            for (int i = 0; i < userWord.Length; i++)
            {
                squareTypes[i] = GetValidSquareTypeSelection(userWord[i]);
            }
            return squareTypes;
        }

        public SquareType GetValidSquareTypeSelection(char letter)
        {
            Message.AskSquareType(letter);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.NotAValidSelection(input, letter);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return ConvertSelectionLetterToSquareType(input);
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "[A-E]") && input.Length == 1;
        }

        public SquareType ConvertSelectionLetterToSquareType(string selectionLetter)
        {
            switch (selectionLetter)
            {
                case "A":
                    return SquareType.Regular;
                    break;
                case "B":
                    return SquareType.DoubleLetter;
                    break;
                case "C":
                    return SquareType.TripleLetter;
                    break;
                case "D":
                    return SquareType.DoubleWord;
                    break;
                case "E":
                default:
                    return SquareType.TripleWord;
                    break;
            }
        }

        public int CalculateWordScore(int[] baseValues, SquareType[] squareTypes)
        {
            var wordScore = 0;
            var wordmultiplier = 1;
            for (int i = 0; i < baseValues.Length; i++)
            {
                var squareType = squareTypes[i];
                switch (squareType)
                {
                    case SquareType.Regular:
                        wordScore += baseValues[i];
                        break;
                    case SquareType.DoubleLetter:
                        wordScore += (baseValues[i] * 2);
                        break;
                    case SquareType.TripleLetter:
                        wordScore += (baseValues[i] * 3);
                        break;
                    case SquareType.DoubleWord:
                        wordScore += baseValues[i];
                        wordmultiplier *= 2;
                        break;
                    case SquareType.TripleWord:
                        wordScore += baseValues[i];
                        wordmultiplier *= 3;
                        break;
                    default:
                        break;
                }
            }
            return wordScore * wordmultiplier;
        }
    }
}
