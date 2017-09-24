using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Manipulation_Messages;
using System.Text.RegularExpressions;

namespace String_Manipulation
{
    public enum Manipulation { Front_Back, Front_Around, Back_Around, Middle_Around, First_3_Times_3, Last_3_Times_3, First_3_Uppercase, Last_3_Uppercase, Double_Characters, Triple_Characters, Reverse_String, Explode_String, Swap_Cases, Shift_Third };
    public class Utility
    {
        public string GetUserString()
        {
            var userInput = "";
            Message.RequestUserString();
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
            return input.Length < 4;
        }

        public string GetSelection()
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
            return Regex.IsMatch(input, "[A-N]") && input.Length == 1;
        }

        public Manipulation ConvertLetterToManipulation(string letterSelected)
        {
            switch (letterSelected)
            {
                case "A":
                    return Manipulation.Front_Back;
                    break;
                case "B":
                    return Manipulation.Front_Around;
                    break;
                case "C":
                    return Manipulation.Back_Around;
                    break;
                case "D":
                    return Manipulation.Middle_Around;
                    break;
                case "E":
                    return Manipulation.First_3_Times_3;
                    break;
                case "F":
                    return Manipulation.Last_3_Times_3;
                    break;
                case "G":
                    return Manipulation.First_3_Uppercase;
                    break;
                case "H":
                    return Manipulation.Last_3_Uppercase;
                    break;
                case "I":
                    return Manipulation.Double_Characters;
                    break;
                case "J":
                    return Manipulation.Triple_Characters;
                    break;
                case "K":
                    return Manipulation.Reverse_String;
                    break;
                case "L":
                    return Manipulation.Explode_String;
                    break;
                case "M":
                    return Manipulation.Swap_Cases;
                    break;
                case "N":
                default:
                    return Manipulation.Shift_Third;
                    break;
            }
        }

        public string FrontBack(string userString)
        {
            return userString[userString.Length - 1] + userString.Substring(1, userString.Length - 2) + userString[0];
        }

        public string FrontAround(string userString)
        {
            return userString[0] + userString + userString[0];
        }

        public string BackAround(string userString)
        {
            return userString[userString.Length - 1] + userString + userString[userString.Length - 1];
        }

        public string MiddleAround(string userString)
        {
            var middle = "";
            if (userString.Length % 2 != 0)
            {
                middle = userString[(userString.Length + 1) / 2 - 1].ToString();
            }
            else
            {
                middle = userString.Substring(userString.Length / 2 - 1, 2);
            }
            return middle + userString + middle;
        }

        public string FirstThree3Times(string userString)
        {
            var firstThree = userString.Substring(0, 3);
            return firstThree + firstThree + firstThree;
        }

        public string LastThree3Times(string userString)
        {
            var lastThree = userString.Substring(userString.Length - 3);
            return lastThree + lastThree + lastThree;
        }

        public string FirstThreeUppercase(string userString)
        {
            return userString.Substring(0, 3).ToUpper() + userString.Substring(3);
        }

        public string LastThreeUppercase(string userString)
        {
            return userString.Substring(0, userString.Length - 3) + userString.Substring(userString.Length - 3).ToUpper();
        }

        public string DoubleCharacters(string userString)
        {
            var newString = "";
            for (int i = 0; i < userString.Length; i++)
            {
                newString += userString[i].ToString() + userString[i].ToString();
            }
            return newString;
        }

        public string TripleCharacters(string userString)
        {
            var newString = "";
            for (int i = 0; i < userString.Length; i++)
            {
                newString += userString[i].ToString() + userString[i].ToString() + userString[i].ToString();
            }
            return newString;
        }

        public string ReverseString(string userString)
        {
            var charArray = userString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string StringExplosion(string userString)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < userString.Length; i++)
            {
                newString.Append(userString.Substring(0, i + 1));
            }
            return newString.ToString();
        }

        public string SwapCases(string userString)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < userString.Length; i++)
            {
                if (Char.IsLower(userString[i]))
                {
                    newString.Append(Char.ToUpper(userString[i]));
                }
                else
                {
                    newString.Append(Char.ToLower(userString[i]));
                }
            }
            return newString.ToString();
        }

        public string ShiftThird(string userString)
        {
            var newString = new StringBuilder();
            for (int i = 0; i < userString.Length - 2; i += 3)
            {
                newString.Append(userString.Substring(i + 1, 2));
                newString.Append(userString.Substring(i, 1));
            }
            return newString.ToString();
        }
    }
}
