using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parrot_Trouble_Messages;

namespace Parrot_Trouble
{
    public class Utility
    {
        public bool AskIfDoing(string activity)
        {
            var IsValidInput = false;
            var input = "";
            Message.EnterIfDoing(activity);
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn(activity);
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

        public bool CheckIfCausingTrouble(bool isSleeping, bool isStudying, bool isMeditating)
        {
            if (isSleeping || isStudying || isMeditating)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayResults(bool isCausingTrouble)
        {
            if (isCausingTrouble)
            {
                Message.CausingTrouble();
            }
            else
            {
                Message.NotCausingTrouble();
            }
        }
    }
}
