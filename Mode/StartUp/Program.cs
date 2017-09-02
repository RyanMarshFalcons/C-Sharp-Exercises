using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mode;
using Mode_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numList = new List<double>();
            var copyOfNumList = new List<double>();
            var num = 0.0;
            var counter = 0;
            var continueAsking = true;
            while (continueAsking == true)
            {
                num = utility.GetValidEntry();
                numList.Add(num);
                copyOfNumList.Add(num);
                continueAsking = utility.AskToContinue();
                counter += 1;
            }
            var maxCount = utility.GetMaxCount(copyOfNumList);
            var modeList = utility.FindTheMode(maxCount, numList);
            Message.OutputMode(counter);
            for (int i = 0; i < modeList.Count; i++)
            {
                Console.WriteLine(modeList[i]);
            }
            Message.CloseProgram();
        }
    }
}
