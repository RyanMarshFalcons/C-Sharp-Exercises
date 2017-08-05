using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicateNums;
using RemoveDuplicateNums_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numList = new List<int>();
            var num = 0;
            var continueAsking = true;
            while (continueAsking == true)
            {
                num = utility.GetValidEntry();
                numList.Add(num);
                continueAsking = utility.AskToContinue();
            }
            var newList = utility.RemoveDuplicates(numList);
            utility.DisplayNewList(newList, numList.Count - newList.Count);
            Console.ReadLine();
        }
    }
}
