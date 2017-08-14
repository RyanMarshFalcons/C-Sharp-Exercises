using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkey_Trouble_Messages;

namespace Monkey_Trouble
{
    public class Utility
    {
        public bool AskIfSmiling(string firstOrSecond)
        {
            var IsValidInput = false;
            var input = "";
            Message.EnterIfSmiling(firstOrSecond);
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn(firstOrSecond);
                }
                else
                {
                    IsValidInput = true;
                }
            }
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfyOrn(string input)
        {
            if ((input == "y") || (input == "n"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AreInTrouble(bool monkey1Smiling, bool monkey2Smiling)
        {
            return monkey1Smiling == monkey2Smiling;
        }

        public void DisplayResults(bool areInTrouble)
        {
            if (areInTrouble)
            {
                Message.InTrouble();
            }
            else
            {
                Message.NotInTrouble();
            }
        }
    }
}
