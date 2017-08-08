using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum_Of_Nums;
using Sum_Of_Nums_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numList = new List<double>();
            var num = 0.0;
            var continueAsking = true;
            while (continueAsking == true)
            {
                num = utility.GetValidEntry();
                numList.Add(num);
                continueAsking = utility.AskToContinue();
            }
            var sum = utility.SumTheNumbers(numList);
            Message.DisplaySum(numList.Count, sum);
            Console.ReadLine();
        }
    }
}
