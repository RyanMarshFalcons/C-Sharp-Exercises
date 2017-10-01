using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divisible_Sum_Pairs;
using Divisible_Sum_Pairs_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var divisibleNum = utility.GetDivisibleNum();
            var listOfNums = new List<int>();
            var counter = 0;
            var continueAsking = true;
            while (continueAsking)
            {
                counter++;
                listOfNums.Add(utility.GetNumForList(counter));
                if (counter > 2)
                {
                    continueAsking = utility.AskToAddAnotherNumberToList();
                }
            }
            var divisibleSumPairs = utility.CalculateDivisibleSumPairs(divisibleNum, listOfNums);
            utility.DisplayResults(divisibleSumPairs, divisibleNum);
            Console.ReadLine();
        }
    }
}
