using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Median;
using Median_Messages;

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
            var counter = 0;
            var continueAsking = true;
            while (continueAsking == true)
            {
                num = utility.GetValidEntry();
                numList.Add(num);
                continueAsking = utility.AskToContinue();
                counter += 1;
            }
            var median = utility.FindTheMedian(counter, numList);
            Message.OutputMedian(counter, median);
            Console.ReadLine();
        }
    }
}
