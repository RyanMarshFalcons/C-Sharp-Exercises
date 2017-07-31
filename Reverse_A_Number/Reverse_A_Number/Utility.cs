using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reverse_A_Number_Messages;

namespace Reverse_A_Number
{
    public class Utility
    {
        public string GetValidEntry()
        {
            Message.EnterNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return Int32.TryParse(input, out num);
        }

        public string InputInReverse(string userInput)
        {
            var userInputAsArray = userInput.ToCharArray();
            Array.Reverse(userInputAsArray);
            return new string(userInputAsArray);
        }
    }
}
