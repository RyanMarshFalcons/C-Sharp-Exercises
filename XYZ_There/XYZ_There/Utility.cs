using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_There_Messages;

namespace XYZ_There
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            Message.RequestUserInput();
            var validEntry = false;
            while (validEntry == false)
            {
                userInput = Console.ReadLine();
                if (CheckIfLongEnough(userInput) == false)
                {
                    Message.NotEnoughCharacters();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfLongEnough(string userInput)
        {
            return userInput.Length >= 3;
        }

        public int GetCount(string userString, string phrase)
        {
            var count = 0;
            for (int i = 0; i < userString.Length - 2; i++)
            {
                if (userString.Substring(i, 3) == phrase)
                {
                    if (i == 0)
                    {
                        count += 1;
                    }
                    else
                    {
                        if (userString.Substring(i - 1, 1) != ".")
                        {
                            count += 1;
                        }
                    }
                }
            }
            return count;
        }
    }
}
