using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwapUpperLowerCases_Messages;

namespace SwapUpperLowerCases
{
    public class Utility
    {
        public string GetUserInput()
        {
            var userInput = "";
            Message.RequestUserInput();
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NoEmptyStrings();
                }
            }
            return userInput;
        }

        public string SwapCases(string userInput)
        {
            var arrUserInput = userInput.ToCharArray();
            for (int i = 0; i < arrUserInput.Length; i++)
            {
                if (Char.IsLower(arrUserInput[i]))
                {
                    arrUserInput[i] = Char.ToUpper(arrUserInput[i]);
                }
                else
                {
                    arrUserInput[i] = Char.ToLower(arrUserInput[i]);
                }
            }
            return new string(arrUserInput); 
        }
    }
}
