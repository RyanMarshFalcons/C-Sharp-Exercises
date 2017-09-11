using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack_Of_Plates_Messages;

namespace Stack_Of_Plates
{
    public class Utility
    {
        public string GetPlateColor(string addRemove)
        {
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.NotAValidSelection(input, addRemove);
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
            return input == "A" || input == "B" || input == "C" || input == "D" || input == "E" || input == "F" || input == "G";
        }

        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherPlate();
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

        public string ConvertLetterToColor(string selection)
        {
            switch (selection)
            {
                case "A":
                    return "Blue";
                    break;
                case "B":
                    return "Red";
                    break;
                case "C":
                    return "Green";
                    break;
                case "D":
                    return "Yellow";
                    break;
                case "E":
                    return "Purple";
                    break;
                case "F":
                    return "Pink";
                    break;
                case "G":
                default:
                    return "Orange";
                    break;
            }
        }

        public int RetrievePlate(Stack<string> plateStack, string colorToRemove)
        {
            var foundPlate = false;
            var counter = 0;
            while (foundPlate == false)
            {
                if (plateStack.Count == 0)
                {
                    return -1;
                }
                else if (plateStack.Peek() == colorToRemove)
                {
                    counter++;
                    foundPlate = true;
                }
                else
                {
                    plateStack.Pop();
                    counter++;
                }
            }
            return counter;
        }

        public bool CheckIfFound(int retrievalCounter)
        {
            return retrievalCounter != -1;
        }

        public void DisplayResults(bool foundPlate, int counter, string colorToRemove)
        {
            if (foundPlate)
            {
                Message.FoundPlate(counter, colorToRemove);
            }
            else
            {
                Message.DidntFindPlate(counter, colorToRemove);
            }
        }
    }
}
