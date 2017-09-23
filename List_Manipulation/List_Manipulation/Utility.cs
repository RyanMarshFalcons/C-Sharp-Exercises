using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List_Manipulation_Messages;
using System.Text.RegularExpressions;

namespace List_Manipulation
{
    public enum Manipulation { Add_Letter_To_Beginning, Add_Letter_To_End, Capitalize_Letters, Delete_Short_Strings, Delete_Long_Strings, Add_Number_To_Beginning, Add_Number_To_End, Add_Dollar_Sign_To_Beginning, Add_Exclamation_Point_To_End};
    public class Utility
    {
        public string GetUserString(int stringNumber)
        {
            var userInput = "";
            Message.RequestUserString(stringNumber);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsTooShort(userInput))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public string GetManipulationSelectionLetter()
        {
            Message.RequestManipulation();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.InvalidSelection(input);
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
            return Regex.IsMatch(input, "[A-I]") && input.Length == 1;
        }

        public Manipulation ConvertLetterToManipulation(string letterSelected)
        {
            switch (letterSelected)
            {
                case "A":
                    return Manipulation.Add_Letter_To_Beginning;
                    break;
                case "B":
                    return Manipulation.Add_Letter_To_End;
                    break;
                case "C":
                    return Manipulation.Capitalize_Letters;
                    break;
                case "D":
                    return Manipulation.Delete_Short_Strings;
                    break;
                case "E":
                    return Manipulation.Delete_Long_Strings;
                    break;
                case "F":
                    return Manipulation.Add_Number_To_Beginning;
                    break;
                case "G":
                    return Manipulation.Add_Number_To_End;
                    break;
                case "H":
                    return Manipulation.Add_Dollar_Sign_To_Beginning;
                    break;
                case "I":
                default:
                    return Manipulation.Add_Exclamation_Point_To_End;
                    break;
            }
        }

        public bool AskToAddAnotherString()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherString();
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }

        public char GetLetter(string beginningEnd)
        {
            Message.AddLetter(beginningEnd);
            var userInput = "";
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfLetter(userInput) == false)
                {
                    Message.NotALetter(userInput, beginningEnd);
                }
                else
                {
                    validInput = true;
                }
            }
            return Char.Parse(userInput);
        }

        public bool CheckIfLetter(string input)
        {
            return input.Length == 1 && Char.IsLetter(Char.Parse(input));
        }

        public int GetNumber(string beginningEnd)
        {
            Message.AddNumber(beginningEnd);
            var userInput = "";
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfNumber(userInput) == false)
                {
                    Message.NotANumber(userInput, beginningEnd);
                }
                else
                {
                    validInput = true;
                }
            }
            return int.Parse(userInput);
        }

        public bool CheckIfNumber(string input)
        {
            var result = 0;
            return int.TryParse(input, out result);
        }

        public int GetLength(string minimumMaximum)
        {
            Message.RemoveStrings(minimumMaximum);
            var userInput = "";
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfValidLength(userInput) == false)
                {
                    Message.InvalidLength(userInput, minimumMaximum);
                }
                else
                {
                    validInput = true;
                }
            }
            return int.Parse(userInput);
        }

        public bool CheckIfValidLength(string input)
        {
            var result = 0;
            var isNum = int.TryParse(input, out result);
            return isNum && int.Parse(input) > 0;
        }

        public List<string> AddToBeginning(List<string> listOfUserStrings, string addOn)
        {
            for (int i = 0; i < listOfUserStrings.Count; i++)
            {
                listOfUserStrings[i] = addOn + listOfUserStrings[i];
            }
            return listOfUserStrings;
        }

        public List<string> AddToEnd(List<string> listOfUserStrings, string addOn)
        {
            for (int i = 0; i < listOfUserStrings.Count; i++)
            {
                listOfUserStrings[i] = listOfUserStrings[i] + addOn;
            }
            return listOfUserStrings;
        }

        public List<string> CapitalizeLetters(List<string> listOfUserStrings)
        {
            for (int i = 0; i < listOfUserStrings.Count; i++)
            {
                listOfUserStrings[i] = listOfUserStrings[i].ToUpper();
            }
            return listOfUserStrings;
        }

        public List<string> RemoveShortStrings(List<string> listOfUserStrings, int minLength)
        {
            var newListOfUserStrings = new List<string>();
            for (int i = 0; i < listOfUserStrings.Count; i++)
            {
                if (listOfUserStrings[i].Length >= minLength)
                {
                    newListOfUserStrings.Add(listOfUserStrings[i]);
                }
            }
            return newListOfUserStrings;
        }

        public List<string> RemoveLongStrings(List<string> listOfUserStrings, int maxLength)
        {
            var newListOfUserStrings = new List<string>();
            for (int i = 0; i < listOfUserStrings.Count; i++)
            {
                if (listOfUserStrings[i].Length <= maxLength)
                {
                    newListOfUserStrings.Add(listOfUserStrings[i]);
                }
            }
            return newListOfUserStrings;
        }
    }
}
