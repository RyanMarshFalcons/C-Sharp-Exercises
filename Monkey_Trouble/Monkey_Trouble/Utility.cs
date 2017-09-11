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
        public bool AskQuestion()
        {
            var IsValidInput = false;
            var input = "";
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

        public bool AreMonkeysSame(bool monkey1Smiling, bool monkey2Smiling)
        {
            return monkey1Smiling == monkey2Smiling;
        }

        public bool AreInTrouble(bool monkeysSame, bool wearingYellow, bool caged)
        {
            return monkeysSame && wearingYellow && !caged;
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
