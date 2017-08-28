using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triple_Count_Messages;

namespace Triple_Count
{
    public class Utility
    {
        public string GetString()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserInput();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string input)
        {
            return input.Length < 3;
        }

        public int CountTriples(string userString)
        {
            int tripleCounter = 0;
            for (int i = 0; i < userString.Length - 2; i++)
            {
                if (userString[i] == userString[i + 1] && userString[i] == userString[i + 2])
                {
                    tripleCounter += 1;
                }
            }
            return tripleCounter;
        }

        public void DisplayResults(int tripleCount)
        {
            if (tripleCount == 0)
            {
                Message.DidntFindTriples();
            }
            else
            {
                Message.FoundTriples(tripleCount);
            }
        }
    }
}
