using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cut_The_Sticks_Messages;

namespace Cut_The_Sticks
{
    public class Utility
    {
        public int GetStickLength(int stickNumber)
        {
            Message.EnterLengthOfStick(stickNumber);
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.StickLengthNotANumber(input, stickNumber);
                }
                else
                {
                    if (!CheckIfPositive(input))
                    {
                        Message.StickLengthMustBePositive(stickNumber);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool AskToAddAnotherStick()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherStick();
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

        public int CalculateNumCuts(List<int> stickLengths)
        {
            stickLengths.Sort();
            var counter = 0;
            var shortestLength = 0;
            Message.DisplayInitialStickLengths(stickLengths, counter, stickLengths.Count);
            while (stickLengths.Count > 0)
            {
                counter ++;
                shortestLength = stickLengths[0];
                for (int i = 0; i < stickLengths.Count; i++)
                {
                    stickLengths[i] = stickLengths[i] - shortestLength;
                }
                stickLengths.RemoveAll(s => s == 0);
                if (stickLengths.Count > 0)
                {
                    Message.DisplayStickLengths(stickLengths, counter, shortestLength, stickLengths.Count);
                }
                else
                {
                    Message.AllSticksAreZero(counter, shortestLength);
                }
            }
            return counter;
        }
    }
}
