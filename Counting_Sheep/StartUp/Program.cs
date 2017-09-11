using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Counting_Sheep;
using Counting_Sheep_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utilty = new Utility();
            var delayLetterSelection = utilty.GetValidDelaySelection();
            var delay = utilty.ConvertLetterToDelay(delayLetterSelection);
            var userName = utilty.GetName();
            var millisecondDelay = utilty.GetMillisecondDelayAsInt(delay);
            for (int i = 1; i < 10000; i++)
            {
                if (i % 10 == 0)
                {
                    utilty.RandomMessage(userName);
                }
                else
                {
                    Message.CountSheep(i);
                }
                Thread.Sleep(millisecondDelay);
            }
            Message.ThankYou(userName);
            Console.ReadLine();
        }
    }
}
