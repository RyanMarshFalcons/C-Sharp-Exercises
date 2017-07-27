using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using Number_Sorter;

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
            var counter = 0;
            var continueAsking = true;
            while (continueAsking == true)
            {
                num = utility.GetValidEntry();
                numList.Add(num);
                continueAsking = utility.AskToContinue();
                counter += 1;
            }
            numList = utility.SortTheNumbers(numList);
            utility.DisplaySortedNumbers(numList, counter);
            Console.ReadLine();
        }
    }
}
