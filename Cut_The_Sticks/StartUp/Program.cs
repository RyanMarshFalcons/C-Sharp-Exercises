using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cut_The_Sticks;
using Cut_The_Sticks_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var stickLengths = new List<int>();
            var counter = 0;
            var continueAsking = true;
            while (continueAsking)
            {
                counter++;
                stickLengths.Add(utility.GetStickLength(counter));
                if (counter > 3)
                {
                    continueAsking = utility.AskToAddAnotherStick();
                }
            }
            var numCuts = utility.CalculateNumCuts(stickLengths);
            Message.DisplayResults(numCuts, counter);
           
            Console.ReadLine();
        }
    }
}
