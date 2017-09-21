using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice_Messages;

namespace Dice
{
    public class Utility
    {
        public int GetValidEntry()
        {
            Message.EnterNumberOfDice();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive();
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

        public List<int> GetDiceRolls(int numRolls)
        {
            var rollsOfDice = new List<int>();
            var random = new Random();
            for (int i = 0; i < numRolls; i++)
            {
                rollsOfDice.Add(random.Next(1, 7));
            }
            return rollsOfDice;
        }

        public int GetSum(List<int> rollsOfDice)
        {
            return rollsOfDice.Sum();
        }
    }
}
