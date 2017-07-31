using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mean;
using Mean_Messages;

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
            var mean = utility.FindTheMean(numList);
            Message.OutputMean(counter, mean);
            Console.ReadLine();
        }
    }
}
