using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acronyms_Messages;

namespace Acronyms
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

        public string ConvertToAcronym(string userInput)
        {
            var acronym = "";
            var inputAsCharArray = userInput.ToCharArray();
            if (Char.IsLetter(inputAsCharArray[0]))
            {
                acronym = inputAsCharArray[0].ToString();
            }
            if (inputAsCharArray.Length > 1)
            {
                for (int i = 1; i < inputAsCharArray.Length -1; i++)
                {
                    if ((inputAsCharArray[i-1] == ' ') && (Char.IsLetter(inputAsCharArray[i])))
                    {
                        acronym += inputAsCharArray[i].ToString();
                    }
                }
            }
            return acronym.ToUpper();
        }

        public void DisplayResults(string userInput, string acronym)
        {
            if (acronym.Length == 0)
            {
                Message.NoLetters();
            }
            else
            {
                Message.DisplayResult(userInput, acronym);
            }
        }
    }
}
