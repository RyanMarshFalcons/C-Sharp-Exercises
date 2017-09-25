using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tea_Party_Messages;

namespace Tea_Party
{
    public class Utility
    {
        public int GetValidNumber(string cupsOrCandy)
        {
            Message.EnterNumber(cupsOrCandy);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, cupsOrCandy);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative(cupsOrCandy);
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

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public string CalculatePartyOutcome(int numTeaCups, int numBiscuits, int numCandyBars)
        {
            if (numTeaCups < 10 || numBiscuits < 5 || numCandyBars < 5)
            {
                return "bad";
            }
            else if (numCandyBars + numBiscuits > numTeaCups && numCandyBars > numBiscuits * 2)
            {
                return "great";
            }
            else
            {
                return "good";
            }
        }
    }
}
