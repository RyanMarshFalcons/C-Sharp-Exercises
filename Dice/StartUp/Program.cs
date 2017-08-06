using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice;
using Dice_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numRolls = utility.GetValidEntry();
            var rollResults = utility.GetDiceRolls(numRolls);
            Message.ShowRolls();
            var sumRolls = utility.GetSum(rollResults);
            Message.DisplaySum(numRolls, sumRolls);
            Console.ReadLine();
        }
    }
}
