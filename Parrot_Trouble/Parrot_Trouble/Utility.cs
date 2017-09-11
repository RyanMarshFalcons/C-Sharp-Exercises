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
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }

        public bool CheckIfCausingTrouble(bool isSleeping, bool isStudying, bool isMeditating)
        {
            return isSleeping || isStudying || isMeditating;
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
