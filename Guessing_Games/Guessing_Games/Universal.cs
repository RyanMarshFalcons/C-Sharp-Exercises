using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace Guessing_Games
{
    public enum GameResult { Won, Lost, Tied};

    public static class Universal
    {
        public static int ConvertToNum(string input)
        {
            var inputAsInt = 0;
            var result = Int32.TryParse(input, out inputAsInt);
            return inputAsInt;
        }

        public static string GetUserInput(int [] validNums)
        {
            var validInput = false;
            var input = "";
            do
            {
                input = Console.ReadLine();
                var inputAsNum = Universal.ConvertToNum(input);
                if (Universal.DetermineIfInputWasValid(inputAsNum, validNums))
                {
                    validInput = true;
                }
                else
                {
                    Message.InvalidInput();
                }
            } while (validInput == false);
            return input;
        }

        public static bool DetermineIfInputWasValid (int input, int[] validSelections)
        {
            var wasInputValid = false;
            foreach (var num in validSelections)
            {
                if (input == num)
                {
                    wasInputValid = true;
                }
            }
            return wasInputValid;
        }
        

    }
}
