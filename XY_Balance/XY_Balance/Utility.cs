using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XY_Balance_Messages;

namespace XY_Balance
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
            return userInput.Length >= 1;
        }

        public int GetCount(string userString, string letter)
        {
            var count = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString.Substring(i, 1) == letter)
                {
                    count += 1;
                }
            }
            return count;
        }

        public bool CheckIfBalance(int xCount, int XCount, int yCount, int YCount)
        {
            return xCount + XCount == yCount + YCount;
        }
    }
}
